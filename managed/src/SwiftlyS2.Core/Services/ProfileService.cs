using SwiftlyS2.Core.Natives;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Diagnostics;

namespace SwiftlyS2.Core.Services;

internal class ProfileService {

  private readonly object _lock = new();
  private bool _enabled = true;

  private readonly List<RecordInfo> _profilerEvents = new();
  private readonly Dictionary<string, Dictionary<string, List<float>>> _resmonTimesTable = new();
  private readonly Dictionary<string, Dictionary<string, long>> _resmonTempTables = new();

  // High-precision timestamping via Stopwatch, mapped to epoch micros
  private readonly long _swBaseTicks;
  private readonly ulong _epochBaseMicros;
  private readonly double _ticksToMicro;
  private readonly double _ticksToMilli;

  private sealed class RecordInfo {
    public char Event { get; set; }
    public ulong Timestamp { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PluginName { get; set; } = string.Empty;
  }

  public ProfileService() {
    _swBaseTicks = Stopwatch.GetTimestamp();
    // Capture epoch micros at approximately the same moment as base ticks
    var epochTicks = DateTimeOffset.UtcNow.Ticks - DateTimeOffset.UnixEpoch.Ticks; // 100ns ticks
    _epochBaseMicros = (ulong)(epochTicks / 10);
    _ticksToMicro = 1_000_000.0 / Stopwatch.Frequency;
    _ticksToMilli = 1_000.0 / Stopwatch.Frequency;
  }

  private ulong NowMicrosecondsSinceUnixEpoch() {
    var deltaTicks = Stopwatch.GetTimestamp() - _swBaseTicks;
    var micros = (ulong)(deltaTicks * _ticksToMicro);
    return _epochBaseMicros + micros;
  }

  public void Enable() {
    lock (_lock) {
      _profilerEvents.Clear();
      _resmonTimesTable.Clear();
      _enabled = true;
    }
  }

  public void Disable() {
    lock (_lock) {
      _enabled = false;
      _resmonTimesTable.Clear();
      _profilerEvents.Clear();
      _resmonTempTables.Clear();
    }
  }

  public bool IsEnabled() {
    lock (_lock) {
      return _enabled;
    }
  }

  public Dictionary<string, Dictionary<string, List<float>>> GetResmonTimeTables() {
    lock (_lock) {
      // return a shallow copy to avoid external mutation
      var copy = new Dictionary<string, Dictionary<string, List<float>>>(StringComparer.Ordinal);
      foreach (var (plugin, kv) in _resmonTimesTable) {
        var inner = new Dictionary<string, List<float>>(StringComparer.Ordinal);
        foreach (var (key, list) in kv) {
          inner[key] = new List<float>(list);
        }
        copy[plugin] = inner;
      }
      return copy;
    }
  }

  public void StartRecordingWithIdentifier(string identifier, string name)
  {
    lock (_lock) {
      if (!_enabled) return;

      if (!_resmonTempTables.TryGetValue(identifier, out var keyToStart)) {
        keyToStart = new Dictionary<string, long>(StringComparer.Ordinal);
        _resmonTempTables[identifier] = keyToStart;
      }

      var startTicks = Stopwatch.GetTimestamp();
      keyToStart[name] = startTicks;

      var ts = NowMicrosecondsSinceUnixEpoch();
      _profilerEvents.Add(new RecordInfo {
        Event = 'B',
        Timestamp = ts,
        Name = name,
        PluginName = identifier,
      });
    }
  }
  public void StopRecordingWithIdentifier(string identifier, string name)
  {
    lock (_lock) {
      if (!_enabled) return;

      if (!_resmonTempTables.TryGetValue(identifier, out var keyToStart)) return;
      if (!keyToStart.TryGetValue(name, out var startTicks)) return;

      var endTicks = Stopwatch.GetTimestamp();
      var deltaTicks = endTicks - startTicks;
      var durationMs = (float)(deltaTicks * _ticksToMilli);

      // store duration
      if (!_resmonTimesTable.TryGetValue(identifier, out var keyToDurations)) {
        keyToDurations = new Dictionary<string, List<float>>(StringComparer.Ordinal);
        _resmonTimesTable[identifier] = keyToDurations;
      }
      if (!keyToDurations.TryGetValue(name, out var durations)) {
        durations = new List<float>();
        keyToDurations[name] = durations;
      }
      durations.Add(durationMs);

      // end event
      var ts = NowMicrosecondsSinceUnixEpoch();
      _profilerEvents.Add(new RecordInfo {
        Event = 'E',
        Timestamp = ts,
        Name = name,
        PluginName = identifier,
      });

      // optional: remove the start to avoid growth
      keyToStart.Remove(name);
    }
  }
  public void RecordTimeWithIdentifier(string identifier, string name, double duration) {
    lock (_lock) {
      if (!_enabled) return;

      if (!_resmonTimesTable.TryGetValue(identifier, out var keyToDurations)) {
        keyToDurations = new Dictionary<string, List<float>>(StringComparer.Ordinal);
        _resmonTimesTable[identifier] = keyToDurations;
      }
      if (!keyToDurations.TryGetValue(name, out var durations)) {
        durations = new List<float>();
        keyToDurations[name] = durations;
      }
      durations.Add((float)duration);
    }
  }

  public void StartRecording(string name) {
    StartRecordingWithIdentifier("SwiftlyS2", name);
  }

  public void StopRecording(string name) {
    StopRecordingWithIdentifier("SwiftlyS2", name);
  }

  public void RecordTime(string name, double duration) {
    RecordTimeWithIdentifier("SwiftlyS2", name, duration);
  }

  public string GenerateJSONPerformance(string pluginId) {
    List<RecordInfo> timings;
    Dictionary<string, Dictionary<string, List<float>>> timesSnapshot;
    lock (_lock) {
      timings = new List<RecordInfo>(_profilerEvents);
      // shallow copy of times table to ensure stable view
      timesSnapshot = new Dictionary<string, Dictionary<string, List<float>>>(StringComparer.Ordinal);
      foreach (var (p, kv) in _resmonTimesTable) {
        var inner = new Dictionary<string, List<float>>(StringComparer.Ordinal);
        foreach (var (k, v) in kv) inner[k] = new List<float>(v);
        timesSnapshot[p] = inner;
      }
    }

    var traceEvents = new List<Dictionary<string, object?>>();

    // Metadata events
    traceEvents.Add(new Dictionary<string, object?> {
      { "args", new Dictionary<string, object?> { { "name", "Swiftly" } } },
      { "cat", "__metadata" },
      { "name", "process_name" },
      { "ph", "M" },
      { "pid", 1 },
      { "tid", 1 },
      { "ts", 0UL },
    });
    traceEvents.Add(new Dictionary<string, object?> {
      { "args", new Dictionary<string, object?> { { "name", "Swiftly Main" } } },
      { "cat", "__metadata" },
      { "name", "thread_name" },
      { "ph", "M" },
      { "pid", 1 },
      { "tid", 1 },
      { "ts", 0UL },
    });
    traceEvents.Add(new Dictionary<string, object?> {
      { "args", new Dictionary<string, object?> { { "name", "Swiftly Profiler" } } },
      { "cat", "__metadata" },
      { "name", "thread_name" },
      { "ph", "M" },
      { "pid", 1 },
      { "tid", 2 },
      { "ts", 0UL },
    });

    var cacheItems = new Dictionary<string, Dictionary<string, string>>(StringComparer.Ordinal);

    foreach (var record in timings) {
      if (!string.IsNullOrEmpty(pluginId) && !string.Equals(pluginId, record.PluginName, StringComparison.Ordinal)) {
        continue;
      }

      if (!cacheItems.TryGetValue(record.PluginName, out var nameCache)) {
        nameCache = new Dictionary<string, string>(StringComparer.Ordinal);
        cacheItems[record.PluginName] = nameCache;
      }

      if (!nameCache.TryGetValue(record.Name, out var eventName) || string.IsNullOrEmpty(eventName)) {
        // resolve stats for this (plugin, name)
        timesSnapshot.TryGetValue(record.PluginName, out var keyToDurations);
        keyToDurations ??= new Dictionary<string, List<float>>(StringComparer.Ordinal);
        keyToDurations.TryGetValue(record.Name, out var calls);
        calls ??= new List<float>();

        float min = 0f, max = 0f, avg = 0f;
        int count = calls.Count;
        if (count > 0) {
          min = calls.Min();
          max = calls.Max();
          avg = calls.Sum() / count;
        }

        string FormatMs(float ms) {
          if (ms < 0.5f) {
            // show as microseconds with .00 suffix
            var us = (ulong)MathF.Max(0f, ms * 1000f);
            return $"{us:d}.00μs";
          }
          return $"{ms:F2}ms";
        }

        var evname = $"{record.Name} [{record.PluginName}] (min={FormatMs(min)},avg={FormatMs(avg)},max={FormatMs(max)},count={(ulong)count})";
        nameCache[record.Name] = evname;
        eventName = evname;
      }

      traceEvents.Add(new Dictionary<string, object?> {
        { "name", eventName },
        { "ph", record.Event == 'B' ? "B" : "E" },
        { "tid", 2 },
        { "pid", 1 },
        { "ts", record.Timestamp },
      });
    }

    var root = new Dictionary<string, object?> {
      { "traceEvents", traceEvents }
    };

    var options = new JsonSerializerOptions {
      PropertyNamingPolicy = null,
      WriteIndented = false,
      DefaultIgnoreCondition = JsonIgnoreCondition.Never,
    };

    return JsonSerializer.Serialize(root, options);
  }
}

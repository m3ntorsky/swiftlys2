#pragma warning disable CS0649

using System.Buffers;
using System.Text;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeResmon {
  private unsafe static delegate* unmanaged<bool> _IsEnabled;
  public unsafe static bool IsEnabled() {
    var ret = _IsEnabled();
    return ret;
  }
  private unsafe static delegate* unmanaged<byte*, byte*, double, void> _RecordTime;
  /// <summary>
  /// time is milliseconds as float (0.123 for 123 nanoseconds)
  /// </summary>
  public unsafe static void RecordTime(string pluginName, string key, double time) {
    var pool = ArrayPool<byte>.Shared;
    var pluginNameLength = Encoding.UTF8.GetByteCount(pluginName);
    var pluginNameBuffer = pool.Rent(pluginNameLength + 1);
    Encoding.UTF8.GetBytes(pluginName, pluginNameBuffer);
    pluginNameBuffer[pluginNameLength] = 0;
    fixed (byte* pluginNameBufferPtr = pluginNameBuffer) {

    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    _RecordTime(pluginNameBufferPtr, keyBufferPtr, time);
    pool.Return(pluginNameBuffer);

    pool.Return(keyBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, byte*, void> _StartRecording;
  public unsafe static void StartRecording(string pluginName, string key) {
    var pool = ArrayPool<byte>.Shared;
    var pluginNameLength = Encoding.UTF8.GetByteCount(pluginName);
    var pluginNameBuffer = pool.Rent(pluginNameLength + 1);
    Encoding.UTF8.GetBytes(pluginName, pluginNameBuffer);
    pluginNameBuffer[pluginNameLength] = 0;
    fixed (byte* pluginNameBufferPtr = pluginNameBuffer) {

    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    _StartRecording(pluginNameBufferPtr, keyBufferPtr);
    pool.Return(pluginNameBuffer);

    pool.Return(keyBuffer);

  }
  }
  }
  private unsafe static delegate* unmanaged<byte*, byte*, void> _StopRecording;
  public unsafe static void StopRecording(string pluginName, string key) {
    var pool = ArrayPool<byte>.Shared;
    var pluginNameLength = Encoding.UTF8.GetByteCount(pluginName);
    var pluginNameBuffer = pool.Rent(pluginNameLength + 1);
    Encoding.UTF8.GetBytes(pluginName, pluginNameBuffer);
    pluginNameBuffer[pluginNameLength] = 0;
    fixed (byte* pluginNameBufferPtr = pluginNameBuffer) {

    var keyLength = Encoding.UTF8.GetByteCount(key);
    var keyBuffer = pool.Rent(keyLength + 1);
    Encoding.UTF8.GetBytes(key, keyBuffer);
    keyBuffer[keyLength] = 0;
    fixed (byte* keyBufferPtr = keyBuffer) {
    _StopRecording(pluginNameBufferPtr, keyBufferPtr);
    pool.Return(pluginNameBuffer);

    pool.Return(keyBuffer);

  }
  }
  }
}

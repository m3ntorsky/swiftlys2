using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.EntitySystem;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEntityInstanceImpl : CEntityInstance {

  public uint Index => Entity?.EntityHandle.EntityIndex ?? uint.MaxValue;

  public string DesignerName => Entity?.DesignerName ?? string.Empty;

  public void AcceptInput<T>(string input, T value, CEntityInstance? activator = null, CEntityInstance? caller = null, int outputID = 0) {
    switch (value) {
      case bool boolValue:
        NativeEntitySystem.AcceptInputBool(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, boolValue, outputID);
        break;
      case int intValue:
        NativeEntitySystem.AcceptInputInt32(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, intValue, outputID);
        break;
      case uint uintValue:
        NativeEntitySystem.AcceptInputUInt32(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, uintValue, outputID);
        break;
      case long longValue:
        NativeEntitySystem.AcceptInputInt64(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, longValue, outputID);
        break;
      case ulong ulongValue:
        NativeEntitySystem.AcceptInputUInt64(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, ulongValue, outputID);
        break;
      case float floatValue:
        NativeEntitySystem.AcceptInputFloat(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, floatValue, outputID);
        break;
      case double doubleValue:
        NativeEntitySystem.AcceptInputDouble(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, doubleValue, outputID);
        break;
      case string stringValue:
        NativeEntitySystem.AcceptInputString(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, stringValue, outputID);
        break;
      default:
        throw new InvalidOperationException($"Unsupported type: {typeof(T).Name}");
    }
  }

  public void AddEntityIOEvent<T>(string input, T value, CEntityInstance? activator = null, CEntityInstance? caller = null, float delay = 0f) {
    switch (value) {
      case bool boolValue:
        NativeEntitySystem.AddEntityIOEventBool(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, boolValue, delay);
        break;
      case int intValue:
        NativeEntitySystem.AddEntityIOEventInt32(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, intValue, delay);
        break;
      case uint uintValue:
        NativeEntitySystem.AddEntityIOEventUInt32(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, uintValue, delay);
        break;
      case long longValue:
        NativeEntitySystem.AddEntityIOEventInt64(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, longValue, delay);
        break;
      case ulong ulongValue:
        NativeEntitySystem.AddEntityIOEventUInt64(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, ulongValue, delay);
        break;
      case float floatValue:
        NativeEntitySystem.AddEntityIOEventFloat(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, floatValue, delay);
        break;
      case double doubleValue:
        NativeEntitySystem.AddEntityIOEventDouble(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, doubleValue, delay);
        break;
      case string stringValue:
        NativeEntitySystem.AddEntityIOEventString(GetHandle(), input, activator?.GetHandle() ?? nint.Zero, caller?.GetHandle() ?? nint.Zero, stringValue, delay);
        break;
      default:
        throw new InvalidOperationException($"Unsupported type: {typeof(T).Name}");
    }
  }

  public void DispatchSpawn(CEntityKeyValues? entityKV = null) {
    NativeEntitySystem.Spawn(GetHandle(), entityKV?.GetHandle() ?? nint.Zero);
  }

  public void Despawn() {
    NativeEntitySystem.Despawn(GetHandle());
  }
}
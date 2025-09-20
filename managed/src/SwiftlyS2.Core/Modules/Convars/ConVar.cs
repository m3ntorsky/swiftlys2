using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.Convars;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Core.Extensions;
using System.Runtime.InteropServices;

namespace SwiftlyS2.Core.Convars;

internal delegate void ConVarCallbackDelegate(int playerId, nint name, nint value);

internal class ConVar<T> : IConVar<T>{

  private Dictionary<int, ConVarCallbackDelegate> _callbacks = new();
  private object _lock = new();

  public string Name { get; set; }

  internal ConVar(string name) {
    Name = name;
  }

  public void AddFlags(ConvarFlags flags)
  {
    NativeConvars.AddFlags(Name, (ulong)flags);
  }

  public void RemoveFlags(ConvarFlags flags)
  {
    NativeConvars.RemoveFlags(Name, (ulong)flags);
  }

  public void ClearFlags()
  {
    NativeConvars.ClearFlags(Name);
  }

  public ConvarFlags GetFlags()
  {
    return (ConvarFlags)NativeConvars.GetFlags(Name);
  }

  public bool HasFlags(ConvarFlags flags)
  {
    return (GetFlags() & flags) == flags;
  }

  public T Value {
    get {
      if (typeof(T) == typeof(bool)) {
        return (T)(object)NativeConvars.GetConvarValueBool(Name);
      }
      else if (typeof(T) == typeof(short)) {
        return (T)(object)NativeConvars.GetConvarValueInt16(Name);
      }
      else if (typeof(T) == typeof(ushort)) {
        return (T)(object)NativeConvars.GetConvarValueUInt16(Name);
      }
      else if (typeof(T) == typeof(int)) {
        return (T)(object)NativeConvars.GetConvarValueInt32(Name);
      }
      else if (typeof(T) == typeof(uint)) {
        return (T)(object)NativeConvars.GetConvarValueUInt32(Name);
      }
      else if (typeof(T) == typeof(float)) {
        return (T)(object)NativeConvars.GetConvarValueFloat(Name);
      }
      else if (typeof(T) == typeof(long)) {
        return (T)(object)NativeConvars.GetConvarValueInt64(Name);
      }
      else if (typeof(T) == typeof(ulong)) {
        return (T)(object)NativeConvars.GetConvarValueUInt64(Name);
      }
      else if (typeof(T) == typeof(double)) {
        return (T)(object)NativeConvars.GetConvarValueDouble(Name);
      }
      else if (typeof(T) == typeof(Color)) {
        return (T)(object)NativeConvars.GetConvarValueColor(Name);
      }
      else if (typeof(T) == typeof(QAngle)) {
        return (T)(object)NativeConvars.GetConvarValueQAngle(Name);
      }
      else if (typeof(T) == typeof(Vector)) {
        return (T)(object)NativeConvars.GetConvarValueVector(Name);
      }
      else if (typeof(T) == typeof(Vector2D)) {
        return (T)(object)NativeConvars.GetConvarValueVector2D(Name);
      }
      else if (typeof(T) == typeof(Vector4D)) {
        return (T)(object)NativeConvars.GetConvarValueVector4D(Name);
      }
      else if (typeof(T) == typeof(string)) {
        return (T)(object)NativeConvars.GetConvarValueString(Name);
      }
      throw new ArgumentException($"Invalid type {typeof(T).Name}");
    }
    set {
      if (value is bool boolValue) {
        NativeConvars.SetConvarValueBool(Name, boolValue);
        return;
      }
      else if (value is short shortValue) {
        NativeConvars.SetConvarValueInt16(Name, shortValue);
        return;
      }
      else if (value is ushort ushortValue) {
        NativeConvars.SetConvarValueUInt16(Name, ushortValue);
        return;
      }
      else if (value is int intValue) {
        NativeConvars.SetConvarValueInt32(Name, intValue);
        return;
      }
      else if (value is uint uintValue) {
        NativeConvars.SetConvarValueUInt32(Name, uintValue);
        return;
      }
      else if (value is float floatValue) {
        NativeConvars.SetConvarValueFloat(Name, floatValue);
        return;
      }
      else if (value is long longValue) {
        NativeConvars.SetConvarValueInt64(Name, longValue);
        return;
      }
      else if (value is ulong ulongValue) {
        NativeConvars.SetConvarValueUInt64(Name, ulongValue);
        return;
      }
      else if (value is double doubleValue) {
        NativeConvars.SetConvarValueDouble(Name, doubleValue);
        return;
      }
      else if (value is Color colorValue) {
        NativeConvars.SetConvarValueColor(Name, colorValue);
        return;
      }
      else if (value is QAngle qAngleValue) {
        NativeConvars.SetConvarValueQAngle(Name, qAngleValue);
        return;
      }
      else if (value is Vector vectorValue) {
        NativeConvars.SetConvarValueVector(Name, vectorValue);
        return;
      }
      else if (value is Vector2D vector2DValue) {
        NativeConvars.SetConvarValueVector2D(Name, vector2DValue);
        return;
      }
      else if (value is Vector4D vector4DValue) {
        NativeConvars.SetConvarValueVector4D(Name, vector4DValue);
        return;
      }
      else if (value is string stringValue) {
        NativeConvars.SetConvarValueString(Name, stringValue);
        return;
      }
      throw new ArgumentException($"Invalid type {typeof(T).Name}");
    }
  }

  public void SetInternal(T value)
  {
    var addr = NativeConvars.GetConvarDataAddress(Name);

    if (addr == nint.Zero) {
      throw new Exception($"Convar {Name} not found.");
    }

    if (value is bool boolValue) {
      addr.Write(boolValue);
      return;
    }
    else if (value is short shortValue) {
      addr.Write(shortValue);
      return;
    }
    else if (value is ushort ushortValue) {
      addr.Write(ushortValue);
      return;
    }
    else if (value is int intValue) {
      addr.Write(intValue);
      return;
    } 
    else if (value is float floatValue) {
      addr.Write(floatValue);
      return;
    }
    else if (value is long longValue) {
      addr.Write(longValue);
      return;
    }
    else if (value is ulong ulongValue) {
      addr.Write(ulongValue);
      return;
    }
    else if (value is double doubleValue) {
      addr.Write(doubleValue);
      return;
    }
    else if (value is Color colorValue) {
      addr.Write(colorValue);
      return;
    }
    else if (value is QAngle qAngleValue) {
      addr.Write(qAngleValue);
      return;
    }
    else if (value is Vector vectorValue) {
      addr.Write(vectorValue);
      return;
    }
    else if (value is Vector2D vector2DValue) {
      addr.Write(vector2DValue);
      return;
    }
    else if (value is Vector4D vector4DValue) {
      addr.Write(vector4DValue);
      return;
    }
    else if (value is string stringValue)
    {
      var ptr = StringPool.Allocate(stringValue);
      addr.Write(ptr);
      return;
    }
    throw new ArgumentException($"Invalid type {typeof(T).Name}");
  }

  public void ReplicateToClient(int clientId, T value)
  {
    if (value is bool boolValue) {
      NativeConvars.SetClientConvarValueBool(clientId, Name, boolValue);
      return;
    }
    else if (value is short shortValue) {
      NativeConvars.SetClientConvarValueInt16(clientId, Name, shortValue);
      return;
    }
    else if (value is ushort ushortValue) {
      NativeConvars.SetClientConvarValueUInt16(clientId, Name, ushortValue);
      return;
    }
    else if (value is int intValue) {
      NativeConvars.SetClientConvarValueInt32(clientId, Name, intValue);
      return;
    }
    else if (value is uint uintValue) {
      NativeConvars.SetClientConvarValueUInt32(clientId, Name, uintValue);
      return;
    }
    else if (value is float floatValue) {
      NativeConvars.SetClientConvarValueFloat(clientId, Name, floatValue);
      return;
    }
    else if (value is long longValue) {
      NativeConvars.SetClientConvarValueInt64(clientId, Name, longValue);
      return;
    }
    else if (value is ulong ulongValue) {
      NativeConvars.SetClientConvarValueUInt64(clientId, Name, ulongValue);
      return;
    }
    else if (value is double doubleValue) {
      NativeConvars.SetClientConvarValueDouble(clientId, Name, doubleValue);
      return;
    }
    else if (value is Color colorValue) {
      NativeConvars.SetClientConvarValueColor(clientId, Name, colorValue);
      return;
    }
    else if (value is QAngle qAngleValue) {
      NativeConvars.SetClientConvarValueQAngle(clientId, Name, qAngleValue);
      return;
    }
    else if (value is Vector vectorValue) {
      NativeConvars.SetClientConvarValueVector(clientId, Name, vectorValue);
      return;
    }
    else if (value is Vector2D vector2DValue) {
      NativeConvars.SetClientConvarValueVector2D(clientId, Name, vector2DValue);
      return;
    }
    else if (value is Vector4D vector4DValue) {
      NativeConvars.SetClientConvarValueVector4D(clientId, Name, vector4DValue);
      return;
    }
    else if (value is string stringValue) {
      NativeConvars.SetClientConvarValueString(clientId, Name, stringValue);
      return;
    }
    throw new ArgumentException($"Invalid type {typeof(T).Name}");
  }

  public void QueryClient(int clientId, Action<string> callback)
  {

    Action? removeSelf = null;
    ConVarCallbackDelegate nativeCallback = (playerId, namePtr, valuePtr) =>
    {
      if (clientId != playerId) return;
      var name = Marshal.PtrToStringAnsi(namePtr);
      if (name != Name) return;
      var value = Marshal.PtrToStringAnsi(valuePtr)!;

      // var convertedValue = (T)Convert.ChangeType(value, typeof(T))!;
      callback(value);
      removeSelf();

    };


    var callbackPtr = Marshal.GetFunctionPointerForDelegate(nativeCallback);

    var listenerId = NativeConvars.AddQueryClientCvarCallback(callbackPtr);
    lock (_lock)
    {
      _callbacks[listenerId] = nativeCallback;
    }

    removeSelf = () => {
      lock (_lock) {
        _callbacks.Remove(listenerId);
        NativeConvars.RemoveQueryClientCvarCallback(listenerId);
      }
    };
    
    NativeConvars.QueryClientConvar(clientId, Name);
  }

}

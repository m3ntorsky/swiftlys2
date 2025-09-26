using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Shared.EntitySystem;

public class CEntityKeyValues : IDisposable
{

  private CEntityKeyValuesSafeHandle _handle;

  public CEntityKeyValues() {
    _handle = new CEntityKeyValuesSafeHandle(NativeCEntityKeyValues.Allocate());
  }

  public void Dispose() {
    _handle.Dispose();
  }

  internal nint GetHandle() {
    return _handle.GetHandle();
  }

  public void SetBool(string key, bool value) {
    NativeCEntityKeyValues.SetBool(GetHandle(), key, value);
  }

  public void SetInt32(string key, int value) {
    NativeCEntityKeyValues.SetInt(GetHandle(), key, value);
  }

  public void SetUInt32(string key, uint value) {
    NativeCEntityKeyValues.SetUint(GetHandle(), key, value);
  }

  public void SetInt64(string key, long value) {
    NativeCEntityKeyValues.SetInt64(GetHandle(), key, value);
  }

  public void SetUInt64(string key, ulong value) {
    NativeCEntityKeyValues.SetUint64(GetHandle(), key, value);
  }

  public void SetFloat(string key, float value) {
    NativeCEntityKeyValues.SetFloat(GetHandle(), key, value);
  }

  public void SetDouble(string key, double value) {
    NativeCEntityKeyValues.SetDouble(GetHandle(), key, value);
  }

  public void SetString(string key, string value) {
    NativeCEntityKeyValues.SetString(GetHandle(), key, value);
  }

  public void SetPtr(string key, nint value) {
    NativeCEntityKeyValues.SetPtr(GetHandle(), key, value);
  }

  public void SetStringToken(string key, CUtlStringToken value) {
    NativeCEntityKeyValues.SetStringToken(GetHandle(), key, value);
  }

  public void SetColor(string key, Color value) {
    NativeCEntityKeyValues.SetColor(GetHandle(), key, value);
  }

  public void SetVector(string key, Vector value) {
    NativeCEntityKeyValues.SetVector(GetHandle(), key, value);
  }

  public void SetVector2D(string key, Vector2D value) {
    NativeCEntityKeyValues.SetVector2D(GetHandle(), key, value);
  }

  public void SetVector4D(string key, Vector4D value) {
    NativeCEntityKeyValues.SetVector4D(GetHandle(), key, value);
  }

  public void SetQAngle(string key, QAngle value) {
    NativeCEntityKeyValues.SetQAngle(GetHandle(), key, value);
  }

  public bool GetBool(string key) {
    return NativeCEntityKeyValues.GetBool(GetHandle(), key);
  }

  public int GetInt32(string key) {
    return NativeCEntityKeyValues.GetInt(GetHandle(), key);
  }

  public uint GetUInt32(string key) {
    return NativeCEntityKeyValues.GetUint(GetHandle(), key);
  }

  public long GetInt64(string key) {
    return NativeCEntityKeyValues.GetInt64(GetHandle(), key);
  }

  public ulong GetUInt64(string key) {
    return NativeCEntityKeyValues.GetUint64(GetHandle(), key);
  }

  public float GetFloat(string key) {
    return NativeCEntityKeyValues.GetFloat(GetHandle(), key);
  }

  public double GetDouble(string key) {
    return NativeCEntityKeyValues.GetDouble(GetHandle(), key);
  }

  public string GetString(string key) {
    return NativeCEntityKeyValues.GetString(GetHandle(), key);
  }

  public nint GetPtr(string key) {
    return NativeCEntityKeyValues.GetPtr(GetHandle(), key);
  }

  public CUtlStringToken GetStringToken(string key) {
    return NativeCEntityKeyValues.GetStringToken(GetHandle(), key);
  }

  public Color GetColor(string key) {
    return NativeCEntityKeyValues.GetColor(GetHandle(), key);
  }

  public Vector GetVector(string key) {
    return NativeCEntityKeyValues.GetVector(GetHandle(), key);
  }

  public Vector2D GetVector2D(string key) {
    return NativeCEntityKeyValues.GetVector2D(GetHandle(), key);
  }

  public Vector4D GetVector4D(string key) {
    return NativeCEntityKeyValues.GetVector4D(GetHandle(), key);
  }

  public QAngle GetQAngle(string key) {
    return NativeCEntityKeyValues.GetQAngle(GetHandle(), key);
  }

  public void Set<T>(string key, T value) {
    if (value is bool boolValue) {
      SetBool(key, boolValue);
    }
    else if (value is int intValue) {
      SetInt32(key, intValue);
    }
    else if (value is uint uintValue) {
      SetUInt32(key, uintValue);
    }
    else if (value is long longValue) {
      SetInt64(key, longValue);
    }
    else if (value is ulong ulongValue) {
      SetUInt64(key, ulongValue);
    }
    else if (value is float floatValue) {
      SetFloat(key, floatValue);
    }
    else if (value is double doubleValue) {
      SetDouble(key, doubleValue);
    }
    else if (value is string stringValue) {
      SetString(key, stringValue);
    }
    else if (value is nint ptrValue) {
      SetPtr(key, ptrValue);
    }
    else if (value is CUtlStringToken stringTokenValue) {
      SetStringToken(key, stringTokenValue);
    }
    else if (value is Color colorValue) {
      SetColor(key, colorValue);
    }
    else if (value is Vector vectorValue) {
      SetVector(key, vectorValue);
    }
    else if (value is Vector2D vector2DValue) {
      SetVector2D(key, vector2DValue);
    }
    else if (value is Vector4D vector4DValue) {
      SetVector4D(key, vector4DValue);
    }
    else if (value is QAngle qAngleValue) {
      SetQAngle(key, qAngleValue);
    }
    else {
      throw new InvalidOperationException($"Unsupported type: {typeof(T).Name}");
    }
  }

  public T Get<T>(string key) {
    if (typeof(T) == typeof(bool)) {
      return (T)(object)GetBool(key);
    }
    else if (typeof(T) == typeof(int)) {
      return (T)(object)GetInt32(key);
    }
    else if (typeof(T) == typeof(uint)) {
      return (T)(object)GetUInt32(key);
    }
    else if (typeof(T) == typeof(long)) {
      return (T)(object)GetInt64(key);
    }
    else if (typeof(T) == typeof(ulong)) {
      return (T)(object)GetUInt64(key);
    }
    else if (typeof(T) == typeof(float)) {
      return (T)(object)GetFloat(key);
    }
    else if (typeof(T) == typeof(double)) {
      return (T)(object)GetDouble(key);
    }
    else if (typeof(T) == typeof(string)) {
      return (T)(object)GetString(key);
    }
    else if (typeof(T) == typeof(nint)) {
      return (T)(object)GetPtr(key);
    }
    else if (typeof(T) == typeof(CUtlStringToken)) {
      return (T)(object)GetStringToken(key);
    }
    else if (typeof(T) == typeof(Color)) {
      return (T)(object)GetColor(key);
    }
    else if (typeof(T) == typeof(Vector)) {
      return (T)(object)GetVector(key);
    }
    else if (typeof(T) == typeof(Vector2D)) {
      return (T)(object)GetVector2D(key);
    }
    else if (typeof(T) == typeof(Vector4D)) {
      return (T)(object)GetVector4D(key);
    }
    else if (typeof(T) == typeof(QAngle)) {
      return (T)(object)GetQAngle(key);
    }
    else {
      throw new InvalidOperationException($"Unsupported type: {typeof(T).Name}");
    }
  }
}

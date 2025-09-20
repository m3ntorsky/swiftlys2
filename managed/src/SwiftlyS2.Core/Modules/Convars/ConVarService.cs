using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Convars;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Convars;

internal enum EConVarType : int
{
  EConVarType_Invalid = -1,
  EConVarType_Bool,
  EConVarType_Int16,
  EConVarType_UInt16,
  EConVarType_Int32,
  EConVarType_UInt32,
  EConVarType_Int64,
  EConVarType_UInt64,
  EConVarType_Float32,
  EConVarType_Float64,
  EConVarType_String,
  EConVarType_Color,
  EConVarType_Vector2,
  EConVarType_Vector3,
  EConVarType_Vector4,
  EConVarType_Qangle,
  EConVarType_MAX
};

internal class ConVarService : IConVarService {

  public IConVar<T>? Find<T>(string name) {

    if (!NativeConvars.ExistsConvar(name)) {
      return null;
    }

    return new ConVar<T>(name);

  }

  public IConVar<T> Create<T>(string name, string helpMessage, T defaultValue, ConvarFlags flags = ConvarFlags.NONE) {
    if (NativeConvars.ExistsConvar(name)) {
      throw new Exception($"Convar {name} already exists.");
    }

    if (defaultValue is bool boolValue) {
      NativeConvars.CreateConvarBool(name, (int)EConVarType.EConVarType_Bool, (ulong)flags, helpMessage, boolValue);
    }
    else if (defaultValue is short shortValue) {
      NativeConvars.CreateConvarInt16(name, (int)EConVarType.EConVarType_Int16, (ulong)flags, helpMessage, shortValue);
    }
    else if (defaultValue is ushort ushortValue) {
      NativeConvars.CreateConvarUInt16(name, (int)EConVarType.EConVarType_UInt16, (ulong)flags, helpMessage, ushortValue);
    }
    else if (defaultValue is int intValue) {
      NativeConvars.CreateConvarInt32(name, (int)EConVarType.EConVarType_Int32, (ulong)flags, helpMessage, intValue);
    }
    else if (defaultValue is uint uintValue) {
      NativeConvars.CreateConvarUInt32(name, (int)EConVarType.EConVarType_UInt32, (ulong)flags, helpMessage, uintValue);
    }
    else if (defaultValue is long longValue) {
      NativeConvars.CreateConvarInt64(name, (int)EConVarType.EConVarType_Int64, (ulong)flags, helpMessage, longValue);
    }
    else if (defaultValue is ulong ulongValue) {
      NativeConvars.CreateConvarUInt64(name, (int)EConVarType.EConVarType_UInt64, (ulong)flags, helpMessage, ulongValue);
    }
    else if (defaultValue is float floatValue) {
      NativeConvars.CreateConvarFloat(name, (int)EConVarType.EConVarType_Float32, (ulong)flags, helpMessage, floatValue);
    }
    else if (defaultValue is double doubleValue) {
      NativeConvars.CreateConvarFloat(name, (int)EConVarType.EConVarType_Float64, (ulong)flags, helpMessage, (float)doubleValue);
    }
    else if (defaultValue is Vector2D vector2Value) {
      NativeConvars.CreateConvarVector2D(name, (int)EConVarType.EConVarType_Vector2, (ulong)flags, helpMessage, vector2Value);
    }
    else if (defaultValue is Vector vector3Value) {
      NativeConvars.CreateConvarVector(name, (int)EConVarType.EConVarType_Vector3, (ulong)flags, helpMessage, vector3Value);
    }
    else if (defaultValue is Vector4D vector4Value) {
      NativeConvars.CreateConvarVector4D(name, (int)EConVarType.EConVarType_Vector4, (ulong)flags, helpMessage, vector4Value);
    }
    else if (defaultValue is QAngle qAngleValue) {
      NativeConvars.CreateConvarQAngle(name, (int)EConVarType.EConVarType_Qangle, (ulong)flags, helpMessage, qAngleValue);
    }
    else if (defaultValue is Color colorValue) {
      NativeConvars.CreateConvarColor(name, (int)EConVarType.EConVarType_Color, (ulong)flags, helpMessage, colorValue);
    }
    else if (defaultValue is string stringValue) {
      NativeConvars.CreateConvarString(name, (int)EConVarType.EConVarType_String, (ulong)flags, helpMessage, stringValue);
    }
    else {
      throw new Exception($"Unsupported type {typeof(T)}.");
    }

    return new ConVar<T>(name);
  }

}
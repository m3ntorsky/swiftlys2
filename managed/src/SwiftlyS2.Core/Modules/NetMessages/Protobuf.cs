using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Natives.NativeObjects;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Core.NetMessages;

internal class Protobuf : NativeHandle, IProtobuf {

  public Protobuf(nint handle) : base(handle) {
  }


  public bool GetBool(string fieldName)
  {
    return NativeNetMessages.GetBool(GetHandle(), fieldName);
  }

  public void SetBool(string fieldName, bool value)
  {
    NativeNetMessages.SetBool(GetHandle(), fieldName, value);
  }

  public void SetInt32(string fieldName, int value)
  {
    NativeNetMessages.SetInt32(GetHandle(), fieldName, value);
  }

  public int GetInt32(string fieldName) {
    return NativeNetMessages.GetInt32(GetHandle(), fieldName);
  }

  public void SetUInt32(string fieldName, uint value) {
    NativeNetMessages.SetUInt32(GetHandle(), fieldName, value);
  }

  public uint GetUInt32(string fieldName) {
    return NativeNetMessages.GetUInt32(GetHandle(), fieldName);
  }


  public void SetInt64(string fieldName, int value)
  {
    NativeNetMessages.SetInt64(GetHandle(), fieldName, value);
  }

  public long GetInt64(string fieldName)
  {
    return NativeNetMessages.GetInt64(GetHandle(), fieldName);
  }

  public void SetUInt64(string fieldName, ulong value) {
    NativeNetMessages.SetUInt64(GetHandle(), fieldName, value);
  }

  public ulong GetUInt64(string fieldName) {
    return NativeNetMessages.GetUInt64(GetHandle(), fieldName);
  }


  public float GetFloat(string fieldName) {
    return NativeNetMessages.GetFloat(GetHandle(), fieldName);
  }

  public void SetFloat(string fieldName, float value) {
    NativeNetMessages.SetFloat(GetHandle(), fieldName, value);
  }

  public double GetDouble(string fieldName) {
    return NativeNetMessages.GetDouble(GetHandle(), fieldName);
  }

  public void SetDouble(string fieldName, double value) {
    NativeNetMessages.SetDouble(GetHandle(), fieldName, value);
  }

  public string GetString(string fieldName) {
    return NativeNetMessages.GetString(GetHandle(), fieldName);
  }

  public void SetString(string fieldName, string value) {   
    NativeNetMessages.SetString(GetHandle(), fieldName, value);
  }

  public void SetBytes(string fieldName, byte[] value) {
    NativeNetMessages.SetBytes(GetHandle(), fieldName, value);
  }

  public byte[] GetBytes(string fieldName) {
    return NativeNetMessages.GetBytes(GetHandle(), fieldName);
  }

  public void SetVector2D(string fieldName, Vector2D value) {
    NativeNetMessages.SetVector2D(GetHandle(), fieldName, value);
  }

  public Vector2D GetVector2D(string fieldName) {
    return NativeNetMessages.GetVector2D(GetHandle(), fieldName);
  }

  public void SetVector(string fieldName, Vector value) {
    NativeNetMessages.SetVector(GetHandle(), fieldName, value);
  }

  public Vector GetVector(string fieldName) {
    return NativeNetMessages.GetVector(GetHandle(), fieldName);
  }

  public void SetColor(string fieldName, Color value) {
    NativeNetMessages.SetColor(GetHandle(), fieldName, value);
  }

  public Color GetColor(string fieldName) {
    return NativeNetMessages.GetColor(GetHandle(), fieldName);
  }

  public void SetQAngle(string fieldName, QAngle value) {
    NativeNetMessages.SetQAngle(GetHandle(), fieldName, value);
  }

  public QAngle GetQAngle(string fieldName) {
    return NativeNetMessages.GetQAngle(GetHandle(), fieldName);
  }


  public unsafe nint GetNestedMessage(string fieldName)
  {
    return NativeNetMessages.GetNestedMessage(GetHandle(), fieldName);
  }


  // Repeated field accessors
  public bool GetRepeatedBool(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedBool(GetHandle(), fieldName, index);
  }

  public void SetRepeatedBool(string fieldName, int index, bool value)
  {
    NativeNetMessages.SetRepeatedBool(GetHandle(), fieldName, index, value);
  }

  public void AddBool(string fieldName, bool value)
  {
    NativeNetMessages.AddBool(GetHandle(), fieldName, value);
  }

  public int GetRepeatedInt32(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedInt32(GetHandle(), fieldName, index);
  }

  public void SetRepeatedInt32(string fieldName, int index, int value)
  {
    NativeNetMessages.SetRepeatedInt32(GetHandle(), fieldName, index, value);
  }

  public void AddInt32(string fieldName, int value)
  {
    NativeNetMessages.AddInt32(GetHandle(), fieldName, value);
  }

  public uint GetRepeatedUInt32(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedUInt32(GetHandle(), fieldName, index);
  }

  public void SetRepeatedUInt32(string fieldName, int index, uint value)
  {
    NativeNetMessages.SetRepeatedUInt32(GetHandle(), fieldName, index, value);
  }

  public void AddUInt32(string fieldName, uint value)
  {
    NativeNetMessages.AddUInt32(GetHandle(), fieldName, value);
  }

  public long GetRepeatedInt64(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedInt64(GetHandle(), fieldName, index);
  }

  public void SetRepeatedInt64(string fieldName, int index, long value)
  {
    NativeNetMessages.SetRepeatedInt64(GetHandle(), fieldName, index, value);
  }

  public void AddInt64(string fieldName, long value)
  {
    NativeNetMessages.AddInt64(GetHandle(), fieldName, value);
  }

  public ulong GetRepeatedUInt64(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedUInt64(GetHandle(), fieldName, index);
  }

  public void SetRepeatedUInt64(string fieldName, int index, ulong value)
  {
    NativeNetMessages.SetRepeatedUInt64(GetHandle(), fieldName, index, value);
  }

  public void AddUInt64(string fieldName, ulong value)
  {
    NativeNetMessages.AddUInt64(GetHandle(), fieldName, value);
  }

  public float GetRepeatedFloat(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedFloat(GetHandle(), fieldName, index);
  }

  public void SetRepeatedFloat(string fieldName, int index, float value)
  {
    NativeNetMessages.SetRepeatedFloat(GetHandle(), fieldName, index, value);
  }

  public void AddFloat(string fieldName, float value)
  {
    NativeNetMessages.AddFloat(GetHandle(), fieldName, value);
  }

  public double GetRepeatedDouble(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedDouble(GetHandle(), fieldName, index);
  }

  public void SetRepeatedDouble(string fieldName, int index, double value)
  {
    NativeNetMessages.SetRepeatedDouble(GetHandle(), fieldName, index, value);
  }

  public void AddDouble(string fieldName, double value)
  {
    NativeNetMessages.AddDouble(GetHandle(), fieldName, value);
  }

  public string GetRepeatedString(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedString(GetHandle(), fieldName, index);
  }

  public void SetRepeatedString(string fieldName, int index, string value)
  {
    NativeNetMessages.SetRepeatedString(GetHandle(), fieldName, index, value);
  }

  public void AddString(string fieldName, string value)
  {
    NativeNetMessages.AddString(GetHandle(), fieldName, value);
  }

  public byte[] GetRepeatedBytes(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedBytes(GetHandle(), fieldName, index);
  }

  public void SetRepeatedBytes(string fieldName, int index, byte[] value)
  {
    NativeNetMessages.SetRepeatedBytes(GetHandle(), fieldName, index, value);
  }

  public void AddBytes(string fieldName, byte[] value)
  {
    NativeNetMessages.AddBytes(GetHandle(), fieldName, value);
  }

  public Vector2D GetRepeatedVector2D(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedVector2D(GetHandle(), fieldName, index);
  }

  public void SetRepeatedVector2D(string fieldName, int index, Vector2D value)
  {
    NativeNetMessages.SetRepeatedVector2D(GetHandle(), fieldName, index, value);
  }

  public void AddVector2D(string fieldName, Vector2D value)
  {
    NativeNetMessages.AddVector2D(GetHandle(), fieldName, value);
  }

  public Vector GetRepeatedVector(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedVector(GetHandle(), fieldName, index);
  }

  public void SetRepeatedVector(string fieldName, int index, Vector value)
  {
    NativeNetMessages.SetRepeatedVector(GetHandle(), fieldName, index, value);
  }

  public void AddVector(string fieldName, Vector value)
  {
    NativeNetMessages.AddVector(GetHandle(), fieldName, value);
  }

  public Color GetRepeatedColor(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedColor(GetHandle(), fieldName, index);
  }

  public void SetRepeatedColor(string fieldName, int index, Color value)
  {
    NativeNetMessages.SetRepeatedColor(GetHandle(), fieldName, index, value);
  }

  public void AddColor(string fieldName, Color value)
  {
    NativeNetMessages.AddColor(GetHandle(), fieldName, value);
  }

  public QAngle GetRepeatedQAngle(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedQAngle(GetHandle(), fieldName, index);
  }

  public void SetRepeatedQAngle(string fieldName, int index, QAngle value)
  {
    NativeNetMessages.SetRepeatedQAngle(GetHandle(), fieldName, index, value);
  }

  public void AddQAngle(string fieldName, QAngle value)
  {
    NativeNetMessages.AddQAngle(GetHandle(), fieldName, value);
  }

  public unsafe nint GetRepeatedNestedMessage(string fieldName, int index)
  {
    return NativeNetMessages.GetRepeatedNestedMessage(GetHandle(), fieldName, index);
  }

  public unsafe nint AddNestedMessage(string fieldName)
  {
    return NativeNetMessages.AddNestedMessage(GetHandle(), fieldName);
  }

}
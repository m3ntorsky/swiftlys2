
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CUserMessageHudMsgImpl : NetMessage<CUserMessageHudMsg>, CUserMessageHudMsg
{
  public CUserMessageHudMsgImpl(nint handle): base(handle)
  {
  }


  public uint Channel
  { get => Accessor.GetUInt32("channel"); set => Accessor.SetUInt32("channel", value); }


  public float X
  { get => Accessor.GetFloat("x"); set => Accessor.SetFloat("x", value); }


  public float Y
  { get => Accessor.GetFloat("y"); set => Accessor.SetFloat("y", value); }


  public int Color1
  { get => Accessor.GetInt32("color1"); set => Accessor.SetInt32("color1", value); }


  public int Color2
  { get => Accessor.GetInt32("color2"); set => Accessor.SetInt32("color2", value); }


  public uint Effect
  { get => Accessor.GetUInt32("effect"); set => Accessor.SetUInt32("effect", value); }


  public string Message
  { get => Accessor.GetString("message"); set => Accessor.SetString("message", value); }

}

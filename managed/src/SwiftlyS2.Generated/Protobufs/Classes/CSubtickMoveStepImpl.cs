
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CSubtickMoveStepImpl : TypedProtobuf<CSubtickMoveStep>, CSubtickMoveStep
{
  public CSubtickMoveStepImpl(nint handle): base(handle)
  {
  }


  public ulong Button
  { get => Accessor.GetUInt64("button"); set => Accessor.SetUInt64("button", value); }


  public bool Pressed
  { get => Accessor.GetBool("pressed"); set => Accessor.SetBool("pressed", value); }


  public float When
  { get => Accessor.GetFloat("when"); set => Accessor.SetFloat("when", value); }


  public float AnalogForwardDelta
  { get => Accessor.GetFloat("analog_forward_delta"); set => Accessor.SetFloat("analog_forward_delta", value); }


  public float AnalogLeftDelta
  { get => Accessor.GetFloat("analog_left_delta"); set => Accessor.SetFloat("analog_left_delta", value); }


  public float AnalogPitchDelta
  { get => Accessor.GetFloat("analog_pitch_delta"); set => Accessor.SetFloat("analog_pitch_delta", value); }


  public float AnalogYawDelta
  { get => Accessor.GetFloat("analog_yaw_delta"); set => Accessor.SetFloat("analog_yaw_delta", value); }

}

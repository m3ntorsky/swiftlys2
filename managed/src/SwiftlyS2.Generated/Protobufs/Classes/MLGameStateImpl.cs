
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class MLGameStateImpl : TypedProtobuf<MLGameState>, MLGameState
{
  public MLGameStateImpl(nint handle, bool isManuallyAllocated): base(handle)
  {
  }


  public MLMatchState Match
  { get => new MLMatchStateImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "match"), false); }


  public MLRoundState Round
  { get => new MLRoundStateImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "round"), false); }


  public IProtobufRepeatedFieldSubMessageType<MLPlayerState> Players
  { get => new ProtobufRepeatedFieldSubMessageType<MLPlayerState>(Accessor, "players"); }

}

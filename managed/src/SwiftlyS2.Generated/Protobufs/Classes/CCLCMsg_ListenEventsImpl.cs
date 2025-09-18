
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CCLCMsg_ListenEventsImpl : TypedProtobuf<CCLCMsg_ListenEvents>, CCLCMsg_ListenEvents
{
  public CCLCMsg_ListenEventsImpl(nint handle): base(handle)
  {
  }


  public IProtobufRepeatedFieldValueType<int> EventMask
  { get => new ProtobufRepeatedFieldValueType<int>(Accessor, "event_mask"); }

}

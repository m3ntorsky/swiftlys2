
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CCLCMsg_ListenEvents : ITypedProtobuf<CCLCMsg_ListenEvents>
{
  static CCLCMsg_ListenEvents ITypedProtobuf<CCLCMsg_ListenEvents>.Wrap(nint handle) => new CCLCMsg_ListenEventsImpl(handle);


  public IProtobufRepeatedFieldValueType<int> EventMask { get; }

}

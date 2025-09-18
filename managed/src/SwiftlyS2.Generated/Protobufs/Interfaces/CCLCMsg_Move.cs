
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCLCMsg_Move : ITypedProtobuf<CCLCMsg_Move>, INetMessage<CCLCMsg_Move>
{
  static int INetMessage<CCLCMsg_Move>.MessageId => 21;
  
  static string INetMessage<CCLCMsg_Move>.MessageName => "CCLCMsg_Move";

  static CCLCMsg_Move ITypedProtobuf<CCLCMsg_Move>.Wrap(nint handle) => new CCLCMsg_MoveImpl(handle);


  public byte[] Data { get; set; }


  public uint LastCommandNumber { get; set; }

}

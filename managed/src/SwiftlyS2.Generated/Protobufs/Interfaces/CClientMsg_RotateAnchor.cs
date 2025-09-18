
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CClientMsg_RotateAnchor : ITypedProtobuf<CClientMsg_RotateAnchor>
{
  static CClientMsg_RotateAnchor ITypedProtobuf<CClientMsg_RotateAnchor>.Wrap(nint handle) => new CClientMsg_RotateAnchorImpl(handle);


  public float Angle { get; set; }

}

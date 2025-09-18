
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_ReportHit : ITypedProtobuf<CCSUsrMsg_ReportHit>, INetMessage<CCSUsrMsg_ReportHit>
{
  static int INetMessage<CCSUsrMsg_ReportHit>.MessageId => 364;
  
  static string INetMessage<CCSUsrMsg_ReportHit>.MessageName => "CCSUsrMsg_ReportHit";

  static CCSUsrMsg_ReportHit ITypedProtobuf<CCSUsrMsg_ReportHit>.Wrap(nint handle) => new CCSUsrMsg_ReportHitImpl(handle);


  public float PosX { get; set; }


  public float PosY { get; set; }


  public float Timestamp { get; set; }


  public float PosZ { get; set; }

}

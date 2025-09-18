
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_UpdateScreenHealthBar : ITypedProtobuf<CCSUsrMsg_UpdateScreenHealthBar>, INetMessage<CCSUsrMsg_UpdateScreenHealthBar>
{
  static int INetMessage<CCSUsrMsg_UpdateScreenHealthBar>.MessageId => 370;
  
  static string INetMessage<CCSUsrMsg_UpdateScreenHealthBar>.MessageName => "CCSUsrMsg_UpdateScreenHealthBar";

  static CCSUsrMsg_UpdateScreenHealthBar ITypedProtobuf<CCSUsrMsg_UpdateScreenHealthBar>.Wrap(nint handle) => new CCSUsrMsg_UpdateScreenHealthBarImpl(handle);


  public int Entidx { get; set; }


  public float HealthratioOld { get; set; }


  public float HealthratioNew { get; set; }


  public int Style { get; set; }

}

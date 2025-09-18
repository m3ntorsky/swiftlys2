
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgTEArmorRicochet : ITypedProtobuf<CMsgTEArmorRicochet>, INetMessage<CMsgTEArmorRicochet>
{
  static int INetMessage<CMsgTEArmorRicochet>.MessageId => 401;
  
  static string INetMessage<CMsgTEArmorRicochet>.MessageName => "CMsgTEArmorRicochet";

  static CMsgTEArmorRicochet ITypedProtobuf<CMsgTEArmorRicochet>.Wrap(nint handle) => new CMsgTEArmorRicochetImpl(handle);


  public Vector Pos { get; set; }


  public Vector Dir { get; set; }

}

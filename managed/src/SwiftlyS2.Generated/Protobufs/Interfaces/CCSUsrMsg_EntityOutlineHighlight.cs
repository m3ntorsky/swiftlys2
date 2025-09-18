
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_EntityOutlineHighlight : ITypedProtobuf<CCSUsrMsg_EntityOutlineHighlight>, INetMessage<CCSUsrMsg_EntityOutlineHighlight>
{
  static int INetMessage<CCSUsrMsg_EntityOutlineHighlight>.MessageId => 371;
  
  static string INetMessage<CCSUsrMsg_EntityOutlineHighlight>.MessageName => "CCSUsrMsg_EntityOutlineHighlight";

  static CCSUsrMsg_EntityOutlineHighlight ITypedProtobuf<CCSUsrMsg_EntityOutlineHighlight>.Wrap(nint handle) => new CCSUsrMsg_EntityOutlineHighlightImpl(handle);


  public int Entidx { get; set; }


  public bool Removehighlight { get; set; }

}

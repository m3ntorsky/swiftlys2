
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CClientMsg_WorldUIControllerHasPanelChangedEvent : ITypedProtobuf<CClientMsg_WorldUIControllerHasPanelChangedEvent>
{
  static CClientMsg_WorldUIControllerHasPanelChangedEvent ITypedProtobuf<CClientMsg_WorldUIControllerHasPanelChangedEvent>.Wrap(nint handle) => new CClientMsg_WorldUIControllerHasPanelChangedEventImpl(handle);


  public bool HasPanel { get; set; }


  public uint ClientEhandle { get; set; }


  public uint LiteralHandType { get; set; }

}

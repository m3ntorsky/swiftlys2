
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CClientMsg_DevPaletteVisibilityChangedEvent : ITypedProtobuf<CClientMsg_DevPaletteVisibilityChangedEvent>
{
  static CClientMsg_DevPaletteVisibilityChangedEvent ITypedProtobuf<CClientMsg_DevPaletteVisibilityChangedEvent>.Wrap(nint handle) => new CClientMsg_DevPaletteVisibilityChangedEventImpl(handle);


  public bool Visible { get; set; }

}

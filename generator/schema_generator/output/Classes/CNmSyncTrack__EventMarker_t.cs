using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmSyncTrack__EventMarker_t : SchemaClass, INmSyncTrack__EventMarker_t {

  public CNmSyncTrack__EventMarker_t(nint handle) : base(handle) {
  }

  public INmPercent_t StartTime {
    get => new NmPercent_t(_Handle + Schema.GetOffset(0x1BCC69006330E7EE));
  }
  public ref CGlobalSymbol ID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x1BCC690095066900));
  }


}
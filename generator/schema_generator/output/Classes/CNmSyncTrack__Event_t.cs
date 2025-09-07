using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmSyncTrack__Event_t : SchemaClass, INmSyncTrack__Event_t {

  public CNmSyncTrack__Event_t(nint handle) : base(handle) {
  }

  public CNmSyncTrack__Event_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CGlobalSymbol ID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x8B8C5B0A95066900));
  }
  public INmPercent_t StartTime {
    get => new NmPercent_t(_Handle + Schema.GetOffset(0x8B8C5B0A6330E7EE));
  }
  public INmPercent_t Duration {
    get => new NmPercent_t(_Handle + Schema.GetOffset(0x8B8C5B0A3D9FF5AD));
  }


}
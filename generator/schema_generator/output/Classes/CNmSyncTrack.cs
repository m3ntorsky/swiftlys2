using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmSyncTrack : SchemaClass, INmSyncTrack {

  public CNmSyncTrack(nint handle) : base(handle) {
  }

  public ISchemaUntypedField SyncEvents {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x29C7FA0336BAB4FF));
  }
  public ref int StartEventOffset {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x29C7FA03DDBC640E));
  }


}
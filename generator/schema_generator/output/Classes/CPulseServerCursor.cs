using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseServerCursor : CPulseExecCursor, IPulseServerCursor {

  public CPulseServerCursor(nint handle) : base(handle) {
  }

  public CPulseServerCursor(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CBaseEntity > Activator {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x4FFA7BD2AB093BB2));
  }
  public ref CHandle< CBaseEntity > Caller {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x4FFA7BD23F9735FC));
  }


}
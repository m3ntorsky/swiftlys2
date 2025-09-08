using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseServerCursor : CPulseExecCursor, IPulseServerCursor {

  public CPulseServerCursor(nint handle) : base(handle) {
  }

  public CHandle<IBaseEntity> Activator {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x4FFA7BD2AB093BB2));
  }
  public CHandle<IBaseEntity> Caller {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x4FFA7BD23F9735FC));
  }


}
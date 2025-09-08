using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRopeOverlapHit : SchemaClass, IRopeOverlapHit {

  public CRopeOverlapHit(nint handle) : base(handle) {
  }

  public CHandle<IBaseEntity> Entity {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x9262EE3E6EBADCB0));
  }
  public ref CUtlVector<int> OverlappingLinks {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0x9262EE3E44D0B359));
  }


}
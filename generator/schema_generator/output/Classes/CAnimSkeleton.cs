using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimSkeleton : SchemaClass, IAnimSkeleton {

  public CAnimSkeleton(nint handle) : base(handle) {
  }

  public CAnimSkeleton(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CTransform > LocalSpaceTransforms {
    get => ref _Handle.AsRef<CUtlVector< CTransform >>(Schema.GetOffset(0x33309AA433B34B4F));
  }
  public ref CUtlVector< CTransform > ModelSpaceTransforms {
    get => ref _Handle.AsRef<CUtlVector< CTransform >>(Schema.GetOffset(0x33309AA4F9870969));
  }
  public ref CUtlVector< CUtlString > BoneNames {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0x33309AA43CC0D1ED));
  }
  public ref CUtlVector< CUtlVector< int32 > > Children {
    get => ref _Handle.AsRef<CUtlVector< CUtlVector< int32 > >>(Schema.GetOffset(0x33309AA47415FA72));
  }
  public ref CUtlVector< int32 > Parents {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x33309AA470DBC8AA));
  }
  public ref CUtlVector< CAnimFoot > Feet {
    get => ref _Handle.AsRef<CUtlVector< CAnimFoot >>(Schema.GetOffset(0x33309AA47910AFF5));
  }
  public ref CUtlVector< CUtlString > MorphNames {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0x33309AA4E8F4EC4F));
  }
  public ref CUtlVector< int32 > LodBoneCounts {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x33309AA4403723B2));
  }


}
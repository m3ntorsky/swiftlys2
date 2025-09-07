using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmBoneWeightList : SchemaClass, INmBoneWeightList {

  public CNmBoneWeightList(nint handle) : base(handle) {
  }

  public CNmBoneWeightList(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField SkeletonName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xA16307391879D68D));
  }
  public ref CUtlVector< CGlobalSymbol > BoneIDs {
    get => ref _Handle.AsRef<CUtlVector< CGlobalSymbol >>(Schema.GetOffset(0xA16307390909C443));
  }
  public ref CUtlVector< float32 > Weights {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0xA163073977B2F91E));
  }


}
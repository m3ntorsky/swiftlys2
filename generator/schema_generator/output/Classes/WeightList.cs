using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class WeightList : SchemaClass, IWeightList {

  public WeightList(nint handle) : base(handle) {
  }

  public WeightList(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x4A08DD454D8F5786));
  }
  public ref CUtlVector< float32 > Weights {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x4A08DD4577B2F91E));
  }


}
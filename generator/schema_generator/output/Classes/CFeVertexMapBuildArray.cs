using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFeVertexMapBuildArray : SchemaClass, IFeVertexMapBuildArray {

  public CFeVertexMapBuildArray(nint handle) : base(handle) {
  }

  public ref CUtlVector<PointerTo<FeVertexMapBuild_t>> Array {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<FeVertexMapBuild_t>>>(Schema.GetOffset(0x7F8ABE7424AA62A6));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class DynamicMeshDeformParams_t : SchemaClass, IDynamicMeshDeformParams_t {

  public DynamicMeshDeformParams_t(nint handle) : base(handle) {
  }

  public ref float TensionCompressScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBC2B1F5B5DC0072F));
  }
  public ref float TensionStretchScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBC2B1F5B0EC210AA));
  }
  public ref bool RecomputeSmoothNormalsAfterAnimation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBC2B1F5BAAFD0999));
  }
  public ref bool ComputeDynamicMeshTensionAfterAnimation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBC2B1F5BDC02C4E8));
  }
  public ref bool SmoothNormalsAcrossUvSeams {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBC2B1F5B6719D8D2));
  }


}
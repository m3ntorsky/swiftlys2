using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnHull_t : SchemaClass, IRnHull_t {

  public RnHull_t(nint handle) : base(handle) {
  }

  public ref Vector Centroid {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x856EB4A1107DFFF1));
  }
  public ref float MaxAngularRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x856EB4A1EF22DA79));
  }
  public IAABB_t Bounds {
    get => new AABB_t(_Handle + Schema.GetOffset(0x856EB4A1ABF76288));
  }
  public ref Vector OrthographicAreas {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x856EB4A1B74855D3));
  }
  public ref matrix3x4_t MassProperties {
    get => ref _Handle.AsRef<matrix3x4_t>(Schema.GetOffset(0x856EB4A1492CEDF8));
  }
  public ref float Volume {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x856EB4A17647E0C9));
  }
  public ref float SurfaceArea {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x856EB4A1E4AE7C2F));
  }
  public ref CUtlVector Vertices {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x856EB4A1E4F9760E));
  }
  public ref CUtlVector<Vector> VertexPositions {
    get => ref _Handle.AsRef<CUtlVector<Vector>>(Schema.GetOffset(0x856EB4A1E553E225));
  }
  public ref CUtlVector Edges {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x856EB4A1CFE839DD));
  }
  public ref CUtlVector Faces {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x856EB4A1B57F1DFD));
  }
  public ref CUtlVector FacePlanes {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x856EB4A1FE0AFD57));
  }
  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x856EB4A1CE6E9C28));
  }
  public IRegionSVM RegionSVM {
    get => new CRegionSVM(_Handle + Schema.GetOffset(0x856EB4A18AD82DC9));
  }


}
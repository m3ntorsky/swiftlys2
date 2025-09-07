using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRenderMesh : SchemaClass, IRenderMesh {

  public CRenderMesh(nint handle) : base(handle) {
  }

  public CRenderMesh(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlLeanVectorFixedGrowable< CSceneObjectData, 1 > SceneObjects {
    get => ref _Handle.AsRef<CUtlLeanVectorFixedGrowable< CSceneObjectData, 1 >>(Schema.GetOffset(0x8593C3BF332235A1));
  }
  public ref CUtlLeanVector< CBaseConstraint* > Constraints {
    get => ref _Handle.AsRef<CUtlLeanVector< CBaseConstraint* >>(Schema.GetOffset(0x8593C3BF251CBAAB));
  }
  public IRenderSkeleton Skeleton {
    get => new CRenderSkeleton(_Handle + Schema.GetOffset(0x8593C3BFE77F030E));
  }
  public ref bool UseUV2ForCharting {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8593C3BFFE2DF46A));
  }
  public ref bool EmbeddedMapMesh {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8593C3BF6E866052));
  }
  public IDynamicMeshDeformParams_t MeshDeformParams {
    get => new DynamicMeshDeformParams_t(_Handle + Schema.GetOffset(0x8593C3BF061DBB9B));
  }
  public IRenderGroom GroomData {
    get => new CRenderGroom(_Handle + Schema.GetOffset(0x8593C3BFCFCDEA93));
  }


}
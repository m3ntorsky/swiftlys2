using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRenderGroom : SchemaClass, IRenderGroom {

  public CRenderGroom(nint handle) : base(handle) {
  }

  public CRenderGroom(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< RenderHairStrandInfo_t > Hairs {
    get => ref _Handle.AsRef<CUtlVector< RenderHairStrandInfo_t >>(Schema.GetOffset(0xC3F698B4E7C4901E));
  }
  public ref CUtlVector< uint32 > HairPositionOffsets {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0xC3F698B40BA9FF3E));
  }
  public ref CStrongHandleCopyable< InfoForResourceTypeIMaterial2 > SimParamsMat {
    get => ref _Handle.AsRef<CStrongHandleCopyable< InfoForResourceTypeIMaterial2 >>(Schema.GetOffset(0xC3F698B4E9EE5886));
  }
  public ref CUtlVector< int32 > StrandSegmentCountHist {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0xC3F698B4D2E373B9));
  }
  public ref int MaxSegmentsPerHairStrand {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3F698B43675C4E2));
  }
  public ref int GuideHairCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3F698B41D073EAE));
  }
  public ref int HairCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3F698B498FBF2A4));
  }
  public ref int TotalVertexCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3F698B40CA035E2));
  }
  public ref int TotalSegmentCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3F698B4AE009BD1));
  }
  public ref int GroomGroupID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3F698B4AD482815));
  }
  public ref int AttachBoneIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3F698B4466DE8A1));
  }
  public ref int AttachMeshIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3F698B4ABA5B148));
  }
  public ref int AttachMeshDrawCallIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC3F698B4E3082962));
  }
  public ref bool EnableSimulation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3F698B4AC53FD21));
  }


}
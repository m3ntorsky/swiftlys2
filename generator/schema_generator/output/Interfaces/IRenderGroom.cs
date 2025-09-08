using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRenderGroom : ISchemaClass {

  public ref CUtlVector Hairs { get; }
  
  public ref CUtlVector<uint> HairPositionOffsets { get; }
  
  public CStrongHandle<Iopyable<InfoForResourceTypeIMaterial2> SimParamsMat { get; }
  
  public ref CUtlVector<int> StrandSegmentCountHist { get; }
  
  public ref int MaxSegmentsPerHairStrand { get; }
  
  public ref int GuideHairCount { get; }
  
  public ref int HairCount { get; }
  
  public ref int TotalVertexCount { get; }
  
  public ref int TotalSegmentCount { get; }
  
  public ref int GroomGroupID { get; }
  
  public ref int AttachBoneIdx { get; }
  
  public ref int AttachMeshIdx { get; }
  
  public ref int AttachMeshDrawCallIdx { get; }
  
  public ref bool EnableSimulation { get; }
  
}
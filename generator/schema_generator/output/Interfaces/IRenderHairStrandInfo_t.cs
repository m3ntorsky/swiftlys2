using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRenderHairStrandInfo_t : ISchemaClass {

  public ISchemaFixedArray<uint> GuideHairIndices_nSurfaceTriIndex { get; }
  
  public ISchemaFixedArray<ushort> GuideBary_vBaseBary { get; }
  
  public ISchemaFixedArray<ushort> RootOffset_flLengthScale { get; }
  
  public ISchemaFixedArray<ushort> PackedBaseUv { get; }
  
  public ref uint PackedSurfaceNormalOs { get; }
  
  public ref uint PackedSurfaceTangentOs { get; }
  
  public ref uint DataOffset_Segments { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderGpuImplicit : IParticleFunctionRenderer {

  public ref bool UsePerParticleRadius { get; }
  
  public ref uint VertexCountKb { get; }
  
  public ref uint IndexCountKb { get; }
  
  public IParticleCollectionRendererFloatInput GridSize { get; }
  
  public IParticleCollectionRendererFloatInput RadiusScale { get; }
  
  public IParticleCollectionRendererFloatInput IsosurfaceThreshold { get; }
  
  public ref int ScaleCP { get; }
  
  public CStrongHandle<IInfoForResourceTypeIMaterial2> Material { get; }
  
}
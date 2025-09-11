using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderBlobs : IParticleFunctionRenderer {

  
  public IParticleCollectionRendererFloatInput CubeWidth { get; }
  
  public IParticleCollectionRendererFloatInput CutoffRadius { get; }
  
  public IParticleCollectionRendererFloatInput RenderRadius { get; }
  
  public ref uint VertexCountKb { get; }
  
  public ref uint IndexCountKb { get; }
  
  public ref int ScaleCP { get; }
  
// CUtlVector< MaterialVariable_t >
  public ref CUtlVector MaterialVars { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> Material { get; }
}
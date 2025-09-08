using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderMaterialProxy : IParticleFunctionRenderer {

  public ref int MaterialControlPoint { get; }
  
  public ref MaterialProxyType_t ProxyType { get; }
  
  public ref CUtlVector MaterialVars { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> OverrideMaterial { get; }
  
  public IParticleCollectionFloatInput MaterialOverrideEnabled { get; }
  
  public IParticleCollectionVecInput ColorScale { get; }
  
  public IPerParticleFloatInput Alpha { get; }
  
  public ref ParticleColorBlendType_t ColorBlendType { get; }
  
}
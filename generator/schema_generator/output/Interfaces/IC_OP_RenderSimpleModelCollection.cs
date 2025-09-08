using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderSimpleModelCollection : IParticleFunctionRenderer {

  public ref bool CenterOffset { get; }
  
  public CStrongHandle<IInfoForResourceTypeCModel> Model { get; }
  
  public IParticleModelInput ModelInput { get; }
  
  public IParticleCollectionFloatInput SizeCullScale { get; }
  
  public ref bool DisableShadows { get; }
  
  public ref bool DisableMotionBlur { get; }
  
  public ref bool AcceptsDecals { get; }
  
  public IPerParticleFloatInput DrawFilter { get; }
  
  public IParticleAttributeIndex_t AngularVelocityField { get; }
  
}
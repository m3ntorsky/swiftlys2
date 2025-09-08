using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderPostProcessing : IParticleFunctionRenderer {

  public IPerParticleFloatInput PostProcessStrength { get; }
  
  public CStrongHandle<IInfoForResourceTypeCPostProcessingResource> PostTexture { get; }
  
  public ref ParticlePostProcessPriorityGroup_t Priority { get; }
  
}
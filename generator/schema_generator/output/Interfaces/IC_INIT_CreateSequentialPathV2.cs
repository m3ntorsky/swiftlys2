using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateSequentialPathV2 : IParticleFunctionInitializer {

  
  public IPerParticleFloatInput MaxDistance { get; }
  
  public IParticleCollectionFloatInput NumToAssign { get; }
  
  public ref bool Loop { get; }
  
  public ref bool CPPairs { get; }
  
  public ref bool SaveOffset { get; }
  
  public IPathParameters PathParams { get; }
}
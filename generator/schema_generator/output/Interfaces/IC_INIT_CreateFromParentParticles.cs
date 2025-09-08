using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateFromParentParticles : IParticleFunctionInitializer {

  public ref float VelocityScale { get; }
  
  public ref float Increment { get; }
  
  public ref bool RandomDistribution { get; }
  
  public ref int RandomSeed { get; }
  
  public ref bool SubFrame { get; }
  
}
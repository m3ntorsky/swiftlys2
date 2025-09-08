using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_PlaneCull : IParticleFunctionInitializer {

  public ref int ControlPoint { get; }
  
  public IParticleCollectionFloatInput Distance { get; }
  
  public ref bool CullInside { get; }
  
}
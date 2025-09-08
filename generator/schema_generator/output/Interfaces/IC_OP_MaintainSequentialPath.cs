using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_MaintainSequentialPath : IParticleFunctionOperator {

  public ref float MaxDistance { get; }
  
  public ref float NumToAssign { get; }
  
  public ref float CohesionStrength { get; }
  
  public ref float Tolerance { get; }
  
  public ref bool Loop { get; }
  
  public ref bool UseParticleCount { get; }
  
  public IPathParameters PathParams { get; }
  
}
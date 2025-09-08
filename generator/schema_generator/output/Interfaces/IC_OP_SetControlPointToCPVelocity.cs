using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointToCPVelocity : IParticleFunctionPreEmission {

  public ref int CPInput { get; }
  
  public ref int CPOutputVel { get; }
  
  public ref bool Normalize { get; }
  
  public ref int CPOutputMag { get; }
  
  public ref int CPField { get; }
  
  public IParticleCollectionVecInput ComparisonVelocity { get; }
  
}
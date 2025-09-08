using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetGravityToCP : IParticleFunctionPreEmission {

  public ref int CPInput { get; }
  
  public ref int CPOutput { get; }
  
  public IParticleCollectionFloatInput Scale { get; }
  
  public ref bool SetOrientation { get; }
  
  public ref bool SetZDown { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetVariable : IParticleFunctionPreEmission {

  public IParticleVariableRef VariableReference { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public ref Vector PositionOffset { get; }
  
  public ref QAngle RotationOffset { get; }
  
  public IParticleCollectionVecInput Input { get; }
  
  public IParticleCollectionFloatInput FloatInput { get; }
  
}
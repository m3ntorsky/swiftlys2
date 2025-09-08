using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetSingleControlPointPosition : IParticleFunctionPreEmission {

  public ref bool SetOnce { get; }
  
  public ref int CP1 { get; }
  
  public IParticleCollectionVecInput CP1Pos { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
}
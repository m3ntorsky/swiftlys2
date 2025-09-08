using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_DragRelativeToPlane : IParticleFunctionOperator {

  public IParticleCollectionFloatInput DragAtPlane { get; }
  
  public IParticleCollectionFloatInput Falloff { get; }
  
  public ref bool Directional { get; }
  
  public IParticleCollectionVecInput PlaneNormal { get; }
  
  public ref int ControlPointNumber { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_VectorFieldSnapshot : IParticleFunctionOperator {

  
  public ref int ControlPointNumber { get; }
  
  public IParticleAttributeIndex_t AttributeToWrite { get; }
  
  public ref int LocalSpaceCP { get; }
  
  public IPerParticleFloatInput Interpolation { get; }
  
  public IPerParticleVecInput Scale { get; }
  
  public ref float BoundaryDampening { get; }
  
  public ref bool SetVelocity { get; }
  
  public ref bool LockToSurface { get; }
  
  public ref float GridSpacing { get; }
}
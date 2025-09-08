using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetPerChildControlPointFromAttribute : IParticleFunctionOperator {

  public ref int ChildGroupID { get; }
  
  public ref int FirstControlPoint { get; }
  
  public ref int NumControlPoints { get; }
  
  public ref int ParticleIncrement { get; }
  
  public ref int FirstSourcePoint { get; }
  
  public ref bool NumBasedOnParticleCount { get; }
  
  public IParticleAttributeIndex_t AttributeToRead { get; }
  
  public ref int CPField { get; }
  
}
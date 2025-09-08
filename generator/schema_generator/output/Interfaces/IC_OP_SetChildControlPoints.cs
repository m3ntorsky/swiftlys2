using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetChildControlPoints : IParticleFunctionOperator {

  public ref int ChildGroupID { get; }
  
  public ref int FirstControlPoint { get; }
  
  public ref int NumControlPoints { get; }
  
  public IParticleCollectionFloatInput FirstSourcePoint { get; }
  
  public ref bool Reverse { get; }
  
  public ref bool SetOrientation { get; }
  
  public ref ParticleOrientationType_t Orientation { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointsToParticle : IParticleFunctionOperator {

  
  public ref int ChildGroupID { get; }
  
  public ref int FirstControlPoint { get; }
  
  public ref int NumControlPoints { get; }
  
  public ref int FirstSourcePoint { get; }
  
  public ref bool SetOrientation { get; }
  
  public ref ParticleOrientationSetMode_t OrientationMode { get; }
  
  public ref ParticleParentSetMode_t SetParent { get; }
}
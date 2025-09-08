using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_PositionLock : IParticleFunctionOperator {

  public IParticleTransformInput TransformInput { get; }
  
  public ref float StartTime_min { get; }
  
  public ref float StartTime_max { get; }
  
  public ref float StartTime_exp { get; }
  
  public ref float EndTime_min { get; }
  
  public ref float EndTime_max { get; }
  
  public ref float EndTime_exp { get; }
  
  public ref float Range { get; }
  
  public IParticleCollectionFloatInput RangeBias { get; }
  
  public ref float JumpThreshold { get; }
  
  public ref float PrevPosScale { get; }
  
  public ref bool LockRot { get; }
  
  public IParticleCollectionVecInput Scale { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IParticleAttributeIndex_t FieldOutputPrev { get; }
  
}
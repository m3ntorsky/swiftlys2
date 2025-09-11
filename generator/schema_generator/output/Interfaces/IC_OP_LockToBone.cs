using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LockToBone : IParticleFunctionOperator {

  
  public IParticleModelInput ModelInput { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public ref float LifeTimeFadeStart { get; }
  
  public ref float LifeTimeFadeEnd { get; }
  
  public ref float JumpThreshold { get; }
  
  public ref float PrevPosScale { get; }
  
  public ISchemaFixedString HitboxSetName { get; }
  
  public ref bool Rigid { get; }
  
  public ref bool UseBones { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public IParticleAttributeIndex_t FieldOutputPrev { get; }
  
  public ref ParticleRotationLockType_t RotationSetType { get; }
  
  public ref bool RigidRotationLock { get; }
  
  public IPerParticleVecInput Rotation { get; }
  
  public IPerParticleFloatInput RotLerp { get; }
}
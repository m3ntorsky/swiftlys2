using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_MoveToHitbox : IParticleFunctionOperator {

  
  public IParticleModelInput ModelInput { get; }
  
  public IParticleTransformInput TransformInput { get; }
  
  public ref float LifeTimeLerpStart { get; }
  
  public ref float LifeTimeLerpEnd { get; }
  
  public ref float PrevPosScale { get; }
  
  public ISchemaFixedString HitboxSetName { get; }
  
  public ref bool UseBones { get; }
  
  public ref HitboxLerpType_t LerpType { get; }
  
  public IPerParticleFloatInput Interpolation { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_SetHitboxToClosest : IParticleFunctionInitializer {

  public ref int ControlPointNumber { get; }
  
  public ref int DesiredHitbox { get; }
  
  public IParticleCollectionVecInput HitBoxScale { get; }
  
  public ISchemaFixedString HitboxSetName { get; }
  
  public ref bool UseBones { get; }
  
  public ref bool UseClosestPointOnHitbox { get; }
  
  public ref ClosestPointTestType_t TestType { get; }
  
  public IParticleCollectionFloatInput HybridRatio { get; }
  
  public ref bool UpdatePosition { get; }
  
}
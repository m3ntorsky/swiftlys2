using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_SetHitboxToModel : IParticleFunctionInitializer {

  
  public ref int ControlPointNumber { get; }
  
  public ref int ForceInModel { get; }
  
  public ref bool EvenDistribution { get; }
  
  public ref int DesiredHitbox { get; }
  
  public IParticleCollectionVecInput HitBoxScale { get; }
  
  public ref Vector DirectionBias { get; }
  
  public ref bool MaintainHitbox { get; }
  
  public ref bool UseBones { get; }
  
  public ISchemaFixedString HitboxSetName { get; }
  
  public IParticleCollectionFloatInput ShellSize { get; }
}
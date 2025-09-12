using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvExplosion : IModelPointEntity {

  
  public ref int Magnitude { get; }
  
  public ref float PlayerDamage { get; }
  
  public ref int RadiusOverride { get; }
  
  public ref float InnerRadius { get; }
  
  public ref float DamageForce { get; }
  
  public ref CHandle<CBaseEntity> Inflictor { get; }
  
  public ref DamageTypes_t CustomDamageType { get; }
  
  public ref bool CreateDebris { get; }
  
  public ISchemaUntypedField CustomEffectName { get; }
  
  public ISchemaUntypedField CustomSoundName { get; }
  
  public ref bool SuppressParticleImpulse { get; }
  
  public ref Class_T ClassIgnore { get; }
  
  public ref Class_T ClassIgnore2 { get; }
  
  public ISchemaUntypedField EntityIgnoreName { get; }
  
  public ref CHandle<CBaseEntity> EntityIgnore { get; }
}
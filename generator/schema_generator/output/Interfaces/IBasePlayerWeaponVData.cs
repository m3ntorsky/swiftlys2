using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBasePlayerWeaponVData : IEntitySubclassVDataBase {

  
  public ISchemaUntypedField WorldModel { get; }
  
  public ISchemaUntypedField ToolsOnlyOwnerModelName { get; }
  
  public ref bool BuiltRightHanded { get; }
  
  public ref bool AllowFlipping { get; }
  
  public ISchemaUntypedField MuzzleAttachment { get; }
  
  public ISchemaUntypedField MuzzleFlashParticle { get; }
  
  public ref CUtlString MuzzleFlashParticleConfig { get; }
  
  public ISchemaUntypedField BarrelSmokeParticle { get; }
  
  public ref byte MuzzleSmokeShotThreshold { get; }
  
  public ref float MuzzleSmokeTimeout { get; }
  
  public ref float MuzzleSmokeDecrementRate { get; }
  
  public ref bool LinkedCooldowns { get; }
  
  public ref ItemFlagTypes_t Flags { get; }
  
  public IAmmoIndex_t PrimaryAmmoType { get; }
  
  public IAmmoIndex_t SecondaryAmmoType { get; }
  
  public ref int MaxClip1 { get; }
  
  public ref int MaxClip2 { get; }
  
  public ref int DefaultClip1 { get; }
  
  public ref int DefaultClip2 { get; }
  
  public ref bool ReserveAmmoAsClips { get; }
  
  public ref bool TreatAsSingleClip { get; }
  
  public ref int Weight { get; }
  
  public ref bool AutoSwitchTo { get; }
  
  public ref bool AutoSwitchFrom { get; }
  
  public ref RumbleEffect_t RumbleEffect { get; }
  
  public ref float DropSpeed { get; }
  
  public ref int Slot { get; }
  
  public ref int Position { get; }
  
  public ISchemaUntypedField ShootSounds { get; }
}
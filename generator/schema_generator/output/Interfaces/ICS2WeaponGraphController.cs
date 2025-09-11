using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICS2WeaponGraphController : IAnimGraphControllerBase {

  
  public ISchemaUntypedField Action { get; }
  
  public ISchemaUntypedField ActionReset { get; }
  
  public ISchemaUntypedField WeaponCategory { get; }
  
  public ISchemaUntypedField WeaponType { get; }
  
  public ISchemaUntypedField WeaponExtraInfo { get; }
  
  public ISchemaUntypedField WeaponAmmo { get; }
  
  public ISchemaUntypedField WeaponAmmoMax { get; }
  
  public ISchemaUntypedField WeaponAmmoReserve { get; }
  
  public ISchemaUntypedField WeaponIsSilenced { get; }
  
  public ISchemaUntypedField WeaponIronsightAmount { get; }
  
  public ISchemaUntypedField IsUsingLegacyModel { get; }
  
  public ISchemaUntypedField IdleVariation { get; }
  
  public ISchemaUntypedField DeployVariation { get; }
  
  public ISchemaUntypedField AttackType { get; }
  
  public ISchemaUntypedField AttackThrowStrength { get; }
  
  public ISchemaUntypedField AttackVariation { get; }
  
  public ISchemaUntypedField InspectVariation { get; }
  
  public ISchemaUntypedField InspectExtraInfo { get; }
  
  public ISchemaUntypedField ReloadStage { get; }
}
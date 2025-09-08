using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCS2WeaponGraphController : CAnimGraphControllerBase, ICS2WeaponGraphController {

  public CCS2WeaponGraphController(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Action {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337E7918619F));
  }
  public ISchemaUntypedField ActionReset {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337E580F422E));
  }
  public ISchemaUntypedField WeaponCategory {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337EE2B7A95D));
  }
  public ISchemaUntypedField WeaponType {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337E0C0E3309));
  }
  public ISchemaUntypedField WeaponExtraInfo {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337EF4004D3D));
  }
  public ISchemaUntypedField WeaponAmmo {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337ED1A06C75));
  }
  public ISchemaUntypedField WeaponAmmoMax {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337EEE4C1969));
  }
  public ISchemaUntypedField WeaponAmmoReserve {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337E000AC7BB));
  }
  public ISchemaUntypedField WeaponIsSilenced {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337EBF4E259C));
  }
  public ISchemaUntypedField WeaponIronsightAmount {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337E4239F6F6));
  }
  public ISchemaUntypedField IsUsingLegacyModel {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337EBA564E5D));
  }
  public ISchemaUntypedField IdleVariation {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337ECF0EF118));
  }
  public ISchemaUntypedField DeployVariation {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337E95BD68D7));
  }
  public ISchemaUntypedField AttackType {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337E0CCFAC15));
  }
  public ISchemaUntypedField AttackThrowStrength {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337EB4387222));
  }
  public ISchemaUntypedField AttackVariation {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337E70A63014));
  }
  public ISchemaUntypedField InspectVariation {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337EBDFCECA4));
  }
  public ISchemaUntypedField InspectExtraInfo {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337EF50D283F));
  }
  public ISchemaUntypedField ReloadStage {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8553337E7F8E072A));
  }


}
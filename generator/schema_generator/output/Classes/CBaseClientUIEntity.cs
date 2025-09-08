using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseClientUIEntity : CBaseModelEntity, IBaseClientUIEntity {

  public CBaseClientUIEntity(nint handle) : base(handle) {
  }

  public IEntityIOOutput CustomOutput0 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x51A22D119AA5C775));
  }
  public IEntityIOOutput CustomOutput1 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x51A22D1199A5C5E2));
  }
  public IEntityIOOutput CustomOutput2 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x51A22D1198A5C44F));
  }
  public IEntityIOOutput CustomOutput3 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x51A22D1197A5C2BC));
  }
  public IEntityIOOutput CustomOutput4 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x51A22D1196A5C129));
  }
  public IEntityIOOutput CustomOutput5 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x51A22D1195A5BF96));
  }
  public IEntityIOOutput CustomOutput6 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x51A22D1194A5BE03));
  }
  public IEntityIOOutput CustomOutput7 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x51A22D1193A5BC70));
  }
  public IEntityIOOutput CustomOutput8 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x51A22D11A2A5D40D));
  }
  public IEntityIOOutput CustomOutput9 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x51A22D11A1A5D27A));
  }

  public void EnabledUpdated() {
    Schema.Update(_Handle, 0x51A22D116154EB7E);
  }
  public void DialogXMLNameUpdated() {
    Schema.Update(_Handle, 0x51A22D11D13858C9);
  }
  public void PanelClassNameUpdated() {
    Schema.Update(_Handle, 0x51A22D115C958CBC);
  }
  public void PanelIDUpdated() {
    Schema.Update(_Handle, 0x51A22D1107A4EF60);
  }
}
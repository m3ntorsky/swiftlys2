using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicAuto : CBaseEntity, ILogicAuto {

  public CLogicAuto(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnMapSpawn {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FA33DC758EC03E5));
  }
  public IEntityIOOutput OnDemoMapSpawn {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FA33DC7798F0A72));
  }
  public IEntityIOOutput OnNewGame {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FA33DC7F77845A4));
  }
  public IEntityIOOutput OnLoadGame {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FA33DC748F2D9A6));
  }
  public IEntityIOOutput OnMapTransition {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FA33DC7EEE1CA9D));
  }
  public IEntityIOOutput OnBackgroundMap {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FA33DC7FD54329A));
  }
  public IEntityIOOutput OnMultiNewMap {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FA33DC74D5DCA0D));
  }
  public IEntityIOOutput OnMultiNewRound {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FA33DC70D4B293F));
  }
  public IEntityIOOutput OnVREnabled {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FA33DC79A1AB4C1));
  }
  public IEntityIOOutput OnVRNotEnabled {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FA33DC745E8A1DA));
  }
  public ISchemaUntypedField Globalstate {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1FA33DC777A86653));
  }


}
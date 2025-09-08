using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGamePlayerZone : CRuleBrushEntity, IGamePlayerZone {

  public CGamePlayerZone(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnPlayerInZone {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x35811C97FBD22730));
  }
  public IEntityIOOutput OnPlayerOutZone {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x35811C97E3DE880D));
  }
  public ISchemaUntypedField PlayersInCount {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x35811C9706A59501));
  }
  public ISchemaUntypedField PlayersOutCount {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x35811C976894D862));
  }


}
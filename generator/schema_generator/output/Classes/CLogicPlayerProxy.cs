using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicPlayerProxy : CLogicalEntity, ILogicPlayerProxy {

  public CLogicPlayerProxy(nint handle) : base(handle) {
  }

  public ref CHandle<CBaseEntity> Player {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x81D444EB68856C16));
  }
  public IEntityIOOutput PlayerHasAmmo {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x81D444EB6A23AB96));
  }
  public IEntityIOOutput PlayerHasNoAmmo {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x81D444EB06CA340D));
  }
  public IEntityIOOutput PlayerDied {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x81D444EBB440E03E));
  }
  public ISchemaUntypedField RequestedPlayerHealth {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x81D444EBF1F83D58));
  }


}
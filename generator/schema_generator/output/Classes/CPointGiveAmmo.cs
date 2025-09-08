using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointGiveAmmo : CPointEntity, IPointGiveAmmo {

  public CPointGiveAmmo(nint handle) : base(handle) {
  }

  public CHandle<IBaseEntity> Activator {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x2A4FB25F9C480B5A));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerDetectBulletFire : CBaseTrigger, ITriggerDetectBulletFire {

  public CTriggerDetectBulletFire(nint handle) : base(handle) {
  }

  public CTriggerDetectBulletFire(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool PlayerFireOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x93930A3D56D51CFE));
  }
  public IEntityIOOutput OnDetectedBulletFire {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x93930A3D11D6C936));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayerBase_CameraServices : CPlayer_CameraServices, ICSPlayerBase_CameraServices {

  public CCSPlayerBase_CameraServices(nint handle) : base(handle) {
  }

  public ref CUtlVector TriggerFogList {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x5B25D902AAF6ED5B));
  }
  public CHandle<IBaseEntity> LastFogTrigger {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x5B25D90218A86E0F));
  }

  public void FOVUpdated() {
    Schema.Update(_Handle, 0x5B25D9023C965687);
  }
  public void FOVStartUpdated() {
    Schema.Update(_Handle, 0x5B25D902612A684D);
  }
  public void FOVTimeUpdated() {
    Schema.Update(_Handle, 0x5B25D9024B291C67);
  }
  public void FOVRateUpdated() {
    Schema.Update(_Handle, 0x5B25D902A334F8AC);
  }
  public void ZoomOwnerUpdated() {
    Schema.Update(_Handle, 0x5B25D902CA6018CF);
  }
}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInfoDynamicShadowHint : CPointEntity, IInfoDynamicShadowHint {

  public CInfoDynamicShadowHint(nint handle) : base(handle) {
  }

  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x46DDE8EE3A7C5965));
  }
  public ref float Range {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x46DDE8EE3FC92844));
  }
  public ref int Importance {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x46DDE8EE85D7F083));
  }
  public ref int LightChoice {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x46DDE8EED82DFBD8));
  }
  public CHandle<IBaseEntity> Light {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x46DDE8EEF68359B1));
  }


}
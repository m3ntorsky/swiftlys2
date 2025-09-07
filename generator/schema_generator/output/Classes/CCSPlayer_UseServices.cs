using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_UseServices : CPlayer_UseServices, ICSPlayer_UseServices {

  public CCSPlayer_UseServices(nint handle) : base(handle) {
  }

  public CCSPlayer_UseServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CBaseEntity > LastKnownUseEntity {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0xE5F718912806F946));
  }
  public IGameTime_t LastUseTimeStamp {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xE5F7189104BF376E));
  }
  public IGameTime_t TimeLastUsedWindow {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xE5F7189165762AEB));
  }


}
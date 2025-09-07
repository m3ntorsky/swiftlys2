using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_RadioServices : CPlayerPawnComponent, ICSPlayer_RadioServices {

  public CCSPlayer_RadioServices(nint handle) : base(handle) {
  }

  public CCSPlayer_RadioServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameTime_t GotHostageTalkTimer {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8E7F7B35729FE1A3));
  }
  public IGameTime_t DefusingTalkTimer {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8E7F7B355AF7F835));
  }
  public IGameTime_t C4PlantTalkTimer {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8E7F7B35CE58ABD4));
  }
  public IGameTime_t RadioTokenSlots {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8E7F7B356FB722D0));
  }
  public ref bool IgnoreRadio {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8E7F7B3562FA7576));
  }


}
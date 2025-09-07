using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayer_WaterServices : CPlayer_WaterServices, ICSPlayer_WaterServices {

  public CCSPlayer_WaterServices(nint handle) : base(handle) {
  }

  public CCSPlayer_WaterServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameTime_t NextDrownDamageTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x81EE3221161B7836));
  }
  public ref int DrownDmgRate {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x81EE3221DB1DC111));
  }
  public IGameTime_t AirFinishedTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x81EE3221F32CD208));
  }
  public ref float WaterJumpTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81EE3221E7A7489F));
  }
  public ref Vector WaterJumpVel {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x81EE3221B3333137));
  }
  public ref float SwimSoundTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81EE32218B6E62D7));
  }


}
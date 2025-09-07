using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicActiveAutosave : CLogicAutosave, ILogicActiveAutosave {

  public CLogicActiveAutosave(nint handle) : base(handle) {
  }

  public CLogicActiveAutosave(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int TriggerHitPoints {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9BBDEF887D8FAE5B));
  }
  public ref float TimeToTrigger {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BBDEF880C3F780D));
  }
  public IGameTime_t StartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x9BBDEF8867FE9DC4));
  }
  public ref float DangerousTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BBDEF8819BC5644));
  }


}
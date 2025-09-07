using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class locksound_t : SchemaClass, Ilocksound_t {

  public locksound_t(nint handle) : base(handle) {
  }

  public locksound_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge LockedSound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xDAD0AE229881D7AB));
  }
  public ref CUtlSymbolLarge UnlockedSound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xDAD0AE227EE88276));
  }
  public IGameTime_t FlwaitSound {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xDAD0AE2297A4A845));
  }


}
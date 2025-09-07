using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class GameTick_t : SchemaClass, IGameTick_t {

  public GameTick_t(nint handle) : base(handle) {
  }

  public GameTick_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x89A0CF8DDCB0894A));
  }


}
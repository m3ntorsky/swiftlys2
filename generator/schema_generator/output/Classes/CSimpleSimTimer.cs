using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSimpleSimTimer : SchemaClass, ISimpleSimTimer {

  public CSimpleSimTimer(nint handle) : base(handle) {
  }

  public CSimpleSimTimer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameTime_t Next {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x4169D31C3BE2574E));
  }
  public ref WorldGroupId_t WorldGroupId {
    get => ref _Handle.AsRef<WorldGroupId_t>(Schema.GetOffset(0x4169D31C7414B193));
  }


}
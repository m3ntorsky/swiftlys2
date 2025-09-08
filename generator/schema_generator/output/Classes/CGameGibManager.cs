using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGameGibManager : CBaseEntity, IGameGibManager {

  public CGameGibManager(nint handle) : base(handle) {
  }

  public ref bool AllowNewGibs {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1068CB09FD80F507));
  }
  public ref int CurrentMaxPieces {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1068CB0999B0D602));
  }
  public ref int MaxPieces {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1068CB092DDFB63D));
  }
  public ref int LastFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1068CB09F0B58C21));
  }


}
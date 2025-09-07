using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterEnemy : CBaseFilter, IFilterEnemy {

  public CFilterEnemy(nint handle) : base(handle) {
  }

  public CFilterEnemy(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge EnemyName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x23F92540C9E922A8));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x23F925405ACFC08D));
  }
  public ref float OuterRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x23F925407B66A818));
  }
  public ref int MaxSquadmatesPerEnemy {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x23F925407AA226A0));
  }
  public ref CUtlSymbolLarge PlayerName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x23F92540DE61DD3B));
  }


}
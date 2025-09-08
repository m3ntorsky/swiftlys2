using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSAdditionalMatchStats_t : CSAdditionalPerRoundStats_t, ISAdditionalMatchStats_t {

  public CSAdditionalMatchStats_t(nint handle) : base(handle) {
  }

  public ref int NumRoundsSurvived {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC1150E685E90));
  }
  public ref int MaxNumRoundsSurvived {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC115C3CE99BC));
  }
  public ref int NumRoundsSurvivedTotal {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC1154AB60BAA));
  }
  public ref int RoundsWonWithoutPurchase {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC115AC7FF6C6));
  }
  public ref int RoundsWonWithoutPurchaseTotal {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC1153AC9D3C8));
  }
  public ref int NumFirstKills {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC115500366CC));
  }
  public ref int NumClutchKills {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC115875D8493));
  }
  public ref int NumPistolKills {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC115079C10BD));
  }
  public ref int NumSniperKills {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC115FAE64E21));
  }
  public ref int NumSuicides {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC11545F754B9));
  }
  public ref int NumTeamKills {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC115033A4DAE));
  }
  public ref int TeamDamage {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x22CBC11516B91240));
  }


}
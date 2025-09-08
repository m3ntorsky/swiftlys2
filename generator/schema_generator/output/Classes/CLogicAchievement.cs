using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicAchievement : CLogicalEntity, ILogicAchievement {

  public CLogicAchievement(nint handle) : base(handle) {
  }

  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE8C4579F3A7C5965));
  }
  public ref CUtlSymbolLarge AchievementEventID {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xE8C4579F12AB7E15));
  }
  public IEntityIOOutput OnFired {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xE8C4579F84825730));
  }


}
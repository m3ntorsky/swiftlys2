using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointOrient : CBaseEntity, IPointOrient {

  public CPointOrient(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge SpawnTargetName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x31E4EBC561780472));
  }
  public ref CHandle<CBaseEntity> Target {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x31E4EBC5CE35901A));
  }
  public ref bool Active {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x31E4EBC58334208F));
  }
  public ref PointOrientGoalDirectionType_t GoalDirection {
    get => ref _Handle.AsRef<PointOrientGoalDirectionType_t>(Schema.GetOffset(0x31E4EBC5EF8D5D0F));
  }
  public ref PointOrientConstraint_t Constraint {
    get => ref _Handle.AsRef<PointOrientConstraint_t>(Schema.GetOffset(0x31E4EBC5A20016CE));
  }
  public ref float MaxTurnRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x31E4EBC5860DD1C6));
  }
  public IGameTime_t LastGameTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x31E4EBC591D10404));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseFlex : CBaseAnimGraph, IBaseFlex {

  public CBaseFlex(nint handle) : base(handle) {
  }

  public IGameTime_t AllowResponsesEndTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xEE4FEF4858EB0248));
  }
  public IGameTime_t LastFlexAnimationTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xEE4FEF48D5ADEDFF));
  }
  public ISceneEventId_t NextSceneEventId {
    get => new SceneEventId_t(_Handle + Schema.GetOffset(0xEE4FEF483756F461));
  }
  public ref bool UpdateLayerPriorities {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEE4FEF48446AC3B9));
  }

  public void FlexWeightUpdated() {
    Schema.Update(_Handle, 0xEE4FEF48AB868EDA);
  }
  public void LookTargetPositionUpdated() {
    Schema.Update(_Handle, 0xEE4FEF480DCD7B00);
  }
  public void BlinktoggleUpdated() {
    Schema.Update(_Handle, 0xEE4FEF48CA230309);
  }
}
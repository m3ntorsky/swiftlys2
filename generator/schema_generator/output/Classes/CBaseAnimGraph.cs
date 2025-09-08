using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseAnimGraph : CBaseModelEntity, IBaseAnimGraph {

  public CBaseAnimGraph(nint handle) : base(handle) {
  }

  public IIChoreoServices ChoreoServices {
    get => new IChoreoServices(_Handle + Schema.GetOffset(0xE501DB1E89C6D559));
  }
  public ref float MaxSlopeDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE501DB1E531F618D));
  }
  public ref Vector LastSlopeCheckPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xE501DB1E586A5E32));
  }
  public ref bool AnimationUpdateScheduled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE501DB1E49747BCF));
  }

  public void InitiallyPopulateInterpHistoryUpdated() {
    Schema.Update(_Handle, 0xE501DB1E3087361C);
  }
  public void AnimGraphUpdateEnabledUpdated() {
    Schema.Update(_Handle, 0xE501DB1E724F7FEE);
  }
  public void ForceUpdated() {
    Schema.Update(_Handle, 0xE501DB1E566BD764);
  }
  public void ForceBoneUpdated() {
    Schema.Update(_Handle, 0xE501DB1EDDAC019E);
  }
  public void RagdollPoseUpdated() {
    Schema.Update(_Handle, 0xE501DB1E49F01F45);
  }
  public void RagdollEnabledUpdated() {
    Schema.Update(_Handle, 0xE501DB1E03EA7599);
  }
  public void RagdollClientSideUpdated() {
    Schema.Update(_Handle, 0xE501DB1EB6A5159C);
  }
}
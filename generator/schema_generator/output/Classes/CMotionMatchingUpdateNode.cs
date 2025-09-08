using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionMatchingUpdateNode : CLeafUpdateNode, IMotionMatchingUpdateNode {

  public CMotionMatchingUpdateNode(nint handle) : base(handle) {
  }

  public IMotionDataSet DataSet {
    get => new CMotionDataSet(_Handle + Schema.GetOffset(0x69501C92DA4F8423));
  }
  public ref CUtlVector Metrics {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x69501C922104DB96));
  }
  public ref CUtlVector<float> Weights {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x69501C9277B2F91E));
  }
  public ref bool SearchEveryTick {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x69501C92F2CEEE05));
  }
  public ref float SearchInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69501C9293E76A9E));
  }
  public ref bool SearchWhenClipEnds {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x69501C926A2E4B81));
  }
  public ref bool SearchWhenGoalChanges {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x69501C927EC9CEE3));
  }
  public IBlendCurve BlendCurve {
    get => new CBlendCurve(_Handle + Schema.GetOffset(0x69501C9291978183));
  }
  public ref float SampleRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69501C922545791F));
  }
  public ref float BlendTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69501C92A6206E9F));
  }
  public ref bool LockClipWhenWaning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x69501C9218DA5DAE));
  }
  public ref float SelectionThreshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69501C92FDC93176));
  }
  public ref float ReselectionTimeWindow {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69501C923E1DEB69));
  }
  public ref bool EnableRotationCorrection {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x69501C922632BA1C));
  }
  public ref bool GoalAssist {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x69501C923FDD6989));
  }
  public ref float GoalAssistDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69501C92593568B0));
  }
  public ref float GoalAssistTolerance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69501C92D338CA16));
  }
  public IAnimInputDamping DistanceScale_Damping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0x69501C92EA57FBF5));
  }
  public ref float DistanceScale_OuterRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69501C92632DCAF8));
  }
  public ref float DistanceScale_InnerRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69501C92A3772AE7));
  }
  public ref float DistanceScale_MaxScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69501C92233075C7));
  }
  public ref float DistanceScale_MinScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x69501C92DE35375D));
  }
  public ref bool EnableDistanceScaling {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x69501C926CF73E92));
  }


}
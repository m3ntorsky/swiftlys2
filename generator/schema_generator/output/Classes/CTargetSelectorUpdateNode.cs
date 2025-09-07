using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTargetSelectorUpdateNode : CAnimUpdateNodeBase, ITargetSelectorUpdateNode {

  public CTargetSelectorUpdateNode(nint handle) : base(handle) {
  }

  public CTargetSelectorUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref TargetSelectorAngleMode_t AngleMode {
    get => ref _Handle.AsRef<TargetSelectorAngleMode_t>(Schema.GetOffset(0x37AB6CCBD21DC8BC));
  }
  public ref CUtlVector< CAnimUpdateNodeRef > Children {
    get => ref _Handle.AsRef<CUtlVector< CAnimUpdateNodeRef >>(Schema.GetOffset(0x37AB6CCB7415FA72));
  }
  public IAnimParamHandle TargetPosition {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x37AB6CCBD1F40125));
  }
  public IAnimParamHandle TargetFacePositionParameter {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x37AB6CCB1102D56F));
  }
  public IAnimParamHandle MoveHeadingParameter {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x37AB6CCB3A7267CF));
  }
  public IAnimParamHandle DesiredMoveHeadingParameter {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x37AB6CCBC6298DFB));
  }
  public ref bool TargetPositionIsWorldSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x37AB6CCBABCF9ECD));
  }
  public ref bool TargetFacePositionIsWorldSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x37AB6CCB504B4258));
  }
  public ref bool EnablePhaseMatching {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x37AB6CCB6BC1372A));
  }
  public ref float PhaseMatchingMaxRootMotionSkip {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x37AB6CCB547A4008));
  }


}
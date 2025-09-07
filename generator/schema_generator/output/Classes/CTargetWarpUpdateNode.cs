using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTargetWarpUpdateNode : CUnaryUpdateNode, ITargetWarpUpdateNode {

  public CTargetWarpUpdateNode(nint handle) : base(handle) {
  }

  public CTargetWarpUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref TargetWarpAngleMode_t AngleMode {
    get => ref _Handle.AsRef<TargetWarpAngleMode_t>(Schema.GetOffset(0xF411CC8D21DC8BC));
  }
  public IAnimParamHandle TargetPositionParameter {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xF411CC8A44B9050));
  }
  public IAnimParamHandle TargetUpVectorParameter {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xF411CC85C2D7DCB));
  }
  public IAnimParamHandle TargetFacePositionParameter {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xF411CC81102D56F));
  }
  public IAnimParamHandle MoveHeadingParameter {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xF411CC83A7267CF));
  }
  public IAnimParamHandle DesiredMoveHeadingParameter {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xF411CC8C6298DFB));
  }
  public ref TargetWarpCorrectionMethod CorrectionMethod {
    get => ref _Handle.AsRef<TargetWarpCorrectionMethod>(Schema.GetOffset(0xF411CC81E19BA51));
  }
  public ref TargetWarpTimingMethod TargetWarpTimingMethod {
    get => ref _Handle.AsRef<TargetWarpTimingMethod>(Schema.GetOffset(0xF411CC8EC684360));
  }
  public ref bool TargetFacePositionIsWorldSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF411CC8504B4258));
  }
  public ref bool TargetPositionIsWorldSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF411CC8ABCF9ECD));
  }
  public ref bool OnlyWarpWhenTagIsFound {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF411CC84B577309));
  }
  public ref bool WarpOrientationDuringTranslation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF411CC85672A125));
  }
  public ref bool WarpAroundCenter {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF411CC8B19C474F));
  }
  public ref float MaxAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF411CC8A4B3D8AE));
  }


}
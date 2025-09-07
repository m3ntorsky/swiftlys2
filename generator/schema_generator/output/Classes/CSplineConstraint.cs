using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSplineConstraint : CPhysConstraint, ISplineConstraint {

  public CSplineConstraint(nint handle) : base(handle) {
  }

  public CSplineConstraint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector AnchorOffsetRestore {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC2DC06A0E08CAB0B));
  }
  public ref CHandle< CBaseEntity > SplineEntity {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0xC2DC06A0C3BD15D5));
  }
  public ref bool EnableLateralConstraint {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC2DC06A0B19E8CC2));
  }
  public ref bool EnableVerticalConstraint {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC2DC06A0767B49F3));
  }
  public ref bool EnableAngularConstraint {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC2DC06A0F98A5C8B));
  }
  public ref bool EnableLimit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC2DC06A044207D3D));
  }
  public ref bool FireEventsOnPath {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC2DC06A00576E172));
  }
  public ref float LinearFrequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC2DC06A02FE6B034));
  }
  public ref float LinarDampingRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC2DC06A0E8F28508));
  }
  public ref float JointFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC2DC06A05CA9FD47));
  }
  public ref Vector PreSolveAnchorPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC2DC06A0C7C3B9AE));
  }


}
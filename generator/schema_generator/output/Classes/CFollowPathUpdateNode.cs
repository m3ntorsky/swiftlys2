using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFollowPathUpdateNode : CUnaryUpdateNode, IFollowPathUpdateNode {

  public CFollowPathUpdateNode(nint handle) : base(handle) {
  }

  public ref float BlendOutTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x20514621EAA5AD2B));
  }
  public ref bool BlockNonPathMovement {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x20514621C6CE607F));
  }
  public ref bool StopFeetAtGoal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x20514621D5900E4B));
  }
  public ref bool ScaleSpeed {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x205146212776330C));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x20514621B731A42F));
  }
  public ref float MinAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x205146210D726024));
  }
  public ref float MaxAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x20514621A4B3D8AE));
  }
  public ref float SpeedScaleBlending {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x205146216C96A1BD));
  }
  public IAnimInputDamping TurnDamping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0x20514621822D585C));
  }
  public ref AnimValueSource FacingTarget {
    get => ref _Handle.AsRef<AnimValueSource>(Schema.GetOffset(0x20514621ED73C452));
  }
  public IAnimParamHandle Param {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x20514621679286A4));
  }
  public ref float TurnToFaceOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x20514621359F1A87));
  }
  public ref bool TurnToFace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x20514621BB363416));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMoverUpdateNode : CUnaryUpdateNode, IMoverUpdateNode {

  public CMoverUpdateNode(nint handle) : base(handle) {
  }

  public IAnimInputDamping Damping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0x42BA18A215440FB5));
  }
  public ref AnimValueSource FacingTarget {
    get => ref _Handle.AsRef<AnimValueSource>(Schema.GetOffset(0x42BA18A2ED73C452));
  }
  public IAnimParamHandle MoveVecParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x42BA18A22C2934BD));
  }
  public IAnimParamHandle MoveHeadingParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x42BA18A283A456D1));
  }
  public IAnimParamHandle TurnToFaceParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x42BA18A275778205));
  }
  public ref float TurnToFaceOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x42BA18A2359F1A87));
  }
  public ref float TurnToFaceLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x42BA18A22A27B7DF));
  }
  public ref bool Additive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42BA18A20FA86105));
  }
  public ref bool ApplyMovement {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42BA18A240CF2252));
  }
  public ref bool OrientMovement {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42BA18A2E957E789));
  }
  public ref bool ApplyRotation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42BA18A25B6A1835));
  }
  public ref bool LimitOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x42BA18A2D127934E));
  }


}
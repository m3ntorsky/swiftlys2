using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMovementComponentUpdater : CAnimComponentUpdater, IMovementComponentUpdater {

  public CMovementComponentUpdater(nint handle) : base(handle) {
  }

  public ref CUtlVector Motors {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xCAAB73FD817BF33));
  }
  public IAnimInputDamping FacingDamping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0xCAAB73F9A430F4B));
  }
  public ref int DefaultMotorIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xCAAB73F5A788411));
  }
  public ref float DefaultRunSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCAAB73F47B9DED8));
  }
  public ref bool MoveVarsDisabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCAAB73FB55A4C6A));
  }
  public ref bool NetworkPath {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCAAB73F86C36FF6));
  }
  public ref bool NetworkFacing {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCAAB73FE3436E8F));
  }
  public IAnimParamHandle ParamHandles {
    get => new CAnimParamHandle(_Handle, 0xCAAB73FF6A771ED, 34, 2, 1);
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAimMatrixUpdateNode : CUnaryUpdateNode, IAimMatrixUpdateNode {

  public CAimMatrixUpdateNode(nint handle) : base(handle) {
  }

  public CAimMatrixUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAimMatrixOpFixedSettings_t OpFixedSettings {
    get => new AimMatrixOpFixedSettings_t(_Handle + Schema.GetOffset(0xB3687A53E533AB09));
  }
  public ref AnimVectorSource Target {
    get => ref _Handle.AsRef<AnimVectorSource>(Schema.GetOffset(0xB3687A53FA08A9E8));
  }
  public IAnimParamHandle ParamIndex {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xB3687A5361990A86));
  }
  public IHSequence Sequence {
    get => new HSequence(_Handle + Schema.GetOffset(0xB3687A53E0A0598E));
  }
  public ref bool ResetChild {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB3687A5365CC88B6));
  }
  public ref bool LockWhenWaning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB3687A53EED48004));
  }


}
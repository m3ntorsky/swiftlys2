using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLookAtUpdateNode : CUnaryUpdateNode, ILookAtUpdateNode {

  public CLookAtUpdateNode(nint handle) : base(handle) {
  }

  public CLookAtUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ILookAtOpFixedSettings_t OpFixedSettings {
    get => new LookAtOpFixedSettings_t(_Handle + Schema.GetOffset(0xC17476D5E533AB09));
  }
  public ref AnimVectorSource Target {
    get => ref _Handle.AsRef<AnimVectorSource>(Schema.GetOffset(0xC17476D5FA08A9E8));
  }
  public IAnimParamHandle ParamIndex {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xC17476D561990A86));
  }
  public IAnimParamHandle WeightParamIndex {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xC17476D50F2AED7A));
  }
  public ref bool ResetChild {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC17476D565CC88B6));
  }
  public ref bool LockWhenWaning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC17476D5EED48004));
  }


}
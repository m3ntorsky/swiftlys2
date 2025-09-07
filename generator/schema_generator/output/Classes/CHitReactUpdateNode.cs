using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHitReactUpdateNode : CUnaryUpdateNode, IHitReactUpdateNode {

  public CHitReactUpdateNode(nint handle) : base(handle) {
  }

  public CHitReactUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IHitReactFixedSettings_t OpFixedSettings {
    get => new HitReactFixedSettings_t(_Handle + Schema.GetOffset(0x64E4D4A7E533AB09));
  }
  public IAnimParamHandle TriggerParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x64E4D4A7AA3B4860));
  }
  public IAnimParamHandle HitBoneParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x64E4D4A70CD5764D));
  }
  public IAnimParamHandle HitOffsetParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x64E4D4A7F1CA4A4A));
  }
  public IAnimParamHandle HitDirectionParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x64E4D4A76F980EDC));
  }
  public IAnimParamHandle HitStrengthParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x64E4D4A7BD447408));
  }
  public ref float MinDelayBetweenHits {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x64E4D4A762EED38E));
  }
  public ref bool ResetChild {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x64E4D4A765CC88B6));
  }


}
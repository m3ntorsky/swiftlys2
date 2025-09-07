using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PredictedDamageTag_t : SchemaClass, IPredictedDamageTag_t {

  public PredictedDamageTag_t(nint handle) : base(handle) {
  }

  public PredictedDamageTag_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameTick_t TagTick {
    get => new GameTick_t(_Handle + Schema.GetOffset(0x43420069BBCAAE16));
  }
  public ref float FlinchModSmall {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4342006970E7E18A));
  }
  public ref float FlinchModLarge {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x43420069E052DA66));
  }
  public ref float FriendlyFireDamageReductionRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x43420069BA6A7F4D));
  }

  public void TagTickUpdated() {
    Schema.Update(_Handle, 0x43420069BBCAAE16);
  }
  public void FlinchModSmallUpdated() {
    Schema.Update(_Handle, 0x4342006970E7E18A);
  }
  public void FlinchModLargeUpdated() {
    Schema.Update(_Handle, 0x43420069E052DA66);
  }
  public void FriendlyFireDamageReductionRatioUpdated() {
    Schema.Update(_Handle, 0x43420069BA6A7F4D);
  }
}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MoodAnimationLayer_t : SchemaClass, IMoodAnimationLayer_t {

  public MoodAnimationLayer_t(nint handle) : base(handle) {
  }

  public MoodAnimationLayer_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x3663914263D22D49));
  }
  public ref bool ActiveListening {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x36639142122973A0));
  }
  public ref bool ActiveTalking {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x366391423033E5C3));
  }
  public ref CUtlVector< MoodAnimation_t > LayerAnimations {
    get => ref _Handle.AsRef<CUtlVector< MoodAnimation_t >>(Schema.GetOffset(0x3663914250279465));
  }
  public IRangeFloat Intensity {
    get => new CRangeFloat(_Handle + Schema.GetOffset(0x3663914267B5578C));
  }
  public IRangeFloat DurationScale {
    get => new CRangeFloat(_Handle + Schema.GetOffset(0x36639142776D4203));
  }
  public ref bool ScaleWithInts {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x366391427C46A077));
  }
  public IRangeFloat NextStart {
    get => new CRangeFloat(_Handle + Schema.GetOffset(0x3663914202956BDE));
  }
  public IRangeFloat StartOffset {
    get => new CRangeFloat(_Handle + Schema.GetOffset(0x3663914269A449AA));
  }
  public IRangeFloat EndOffset {
    get => new CRangeFloat(_Handle + Schema.GetOffset(0x36639142C863E027));
  }
  public ref float FadeIn {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x36639142FCA835D2));
  }
  public ref float FadeOut {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x36639142FEBCE80B));
  }


}
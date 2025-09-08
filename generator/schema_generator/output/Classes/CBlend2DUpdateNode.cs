using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBlend2DUpdateNode : CAnimUpdateNodeBase, IBlend2DUpdateNode {

  public CBlend2DUpdateNode(nint handle) : base(handle) {
  }

  public ref CUtlVector Items {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xEA40B5A7A87EDAF));
  }
  public ref CUtlVector Tags {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xEA40B5AB46C8540));
  }
  public IParamSpanUpdater ParamSpans {
    get => new CParamSpanUpdater(_Handle + Schema.GetOffset(0xEA40B5ADAC91553));
  }
  public ref CUtlVector<int> NodeItemIndices {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0xEA40B5AE050EB13));
  }
  public IAnimInputDamping Damping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0xEA40B5A15440FB5));
  }
  public ref AnimValueSource BlendSourceX {
    get => ref _Handle.AsRef<AnimValueSource>(Schema.GetOffset(0xEA40B5A6AABD08F));
  }
  public IAnimParamHandle ParamX {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xEA40B5A4D0E84BE));
  }
  public ref AnimValueSource BlendSourceY {
    get => ref _Handle.AsRef<AnimValueSource>(Schema.GetOffset(0xEA40B5A69ABCEFC));
  }
  public IAnimParamHandle ParamY {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xEA40B5A4E0E8651));
  }
  public ref Blend2DMode BlendMode {
    get => ref _Handle.AsRef<Blend2DMode>(Schema.GetOffset(0xEA40B5ADBED6224));
  }
  public ref float PlaybackSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEA40B5A1AFA7387));
  }
  public ref bool Loop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEA40B5AC668A4CB));
  }
  public ref bool LockBlendOnReset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEA40B5A76334223));
  }
  public ref bool LockWhenWaning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEA40B5AEED48004));
  }
  public ref bool AnimEventsAndTagsOnMostWeightedOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEA40B5AB97E1262));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCycleControlClipUpdateNode : CLeafUpdateNode, ICycleControlClipUpdateNode {

  public CCycleControlClipUpdateNode(nint handle) : base(handle) {
  }

  public ref CUtlVector Tags {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x57FEB5AAB46C8540));
  }
  public IHSequence Sequence {
    get => new HSequence(_Handle + Schema.GetOffset(0x57FEB5AAE0A0598E));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x57FEB5AA3D9FF5AD));
  }
  public ref AnimValueSource ValueSource {
    get => ref _Handle.AsRef<AnimValueSource>(Schema.GetOffset(0x57FEB5AAD4D5B6B7));
  }
  public IAnimParamHandle ParamIndex {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x57FEB5AA61990A86));
  }
  public ref bool LockWhenWaning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x57FEB5AAEED48004));
  }


}
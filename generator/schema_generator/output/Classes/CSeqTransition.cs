using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqTransition : SchemaClass, ISeqTransition {

  public CSeqTransition(nint handle) : base(handle) {
  }

  public ref float FadeInTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF641804E1F0255B3));
  }
  public ref float FadeOutTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF641804EE86D2FC2));
  }


}
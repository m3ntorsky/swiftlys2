using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCycleControlUpdateNode : CUnaryUpdateNode, ICycleControlUpdateNode {

  public CCycleControlUpdateNode(nint handle) : base(handle) {
  }

  public ref AnimValueSource ValueSource {
    get => ref _Handle.AsRef<AnimValueSource>(Schema.GetOffset(0xB811C15CD4D5B6B7));
  }
  public IAnimParamHandle ParamIndex {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xB811C15C61990A86));
  }
  public ref bool LockWhenWaning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB811C15CEED48004));
  }


}
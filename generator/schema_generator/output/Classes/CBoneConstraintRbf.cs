using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBoneConstraintRbf : CBoneConstraintBase, IBoneConstraintRbf {

  public CBoneConstraintRbf(nint handle) : base(handle) {
  }

  public ref CUtlVector InputBones {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x45CB33BF83336B6E));
  }
  public ref CUtlVector OutputBones {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x45CB33BF84D3A41B));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBoneConstraintPoseSpaceBone : CBaseConstraint, IBoneConstraintPoseSpaceBone {

  public CBoneConstraintPoseSpaceBone(nint handle) : base(handle) {
  }

  public ref CUtlVector InputList {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x496EBC215EB8D83));
  }


}
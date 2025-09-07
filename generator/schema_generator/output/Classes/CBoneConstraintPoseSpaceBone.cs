using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBoneConstraintPoseSpaceBone : CBaseConstraint, IBoneConstraintPoseSpaceBone {

  public CBoneConstraintPoseSpaceBone(nint handle) : base(handle) {
  }

  public CBoneConstraintPoseSpaceBone(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CBoneConstraintPoseSpaceBone::Input_t > InputList {
    get => ref _Handle.AsRef<CUtlVector< CBoneConstraintPoseSpaceBone::Input_t >>(Schema.GetOffset(0x496EBC215EB8D83));
  }


}
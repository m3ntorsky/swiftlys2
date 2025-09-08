using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBoneConstraintPoseSpaceMorph__Input_t : SchemaClass, IBoneConstraintPoseSpaceMorph__Input_t {

  public CBoneConstraintPoseSpaceMorph__Input_t(nint handle) : base(handle) {
  }

  public ref Vector InputValue {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x2DF008994039DA98));
  }
  public ref CUtlVector<float> OutputWeightList {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x2DF00899567B1A1C));
  }


}
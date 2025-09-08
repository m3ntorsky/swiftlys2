using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SimpleConstraintSoundProfile : SchemaClass, ISimpleConstraintSoundProfile {

  public SimpleConstraintSoundProfile(nint handle) : base(handle) {
  }

  public ref SimpleConstraintSoundProfile::SimpleConstraintsSoundProfileKeypoints_t Keypoints {
    get => ref _Handle.AsRef<SimpleConstraintSoundProfile::SimpleConstraintsSoundProfileKeypoints_t>(Schema.GetOffset(0xB768AA94AE55150C));
  }
  public ISchemaFixedArray<float> KeyPoints {
    get => new SchemaFixedArray<float>(_Handle, 0xB768AA9449DA0463, 2, 4, 4);
  }
  public ISchemaFixedArray<float> ReversalSoundThresholds {
    get => new SchemaFixedArray<float>(_Handle, 0xB768AA9405E06766, 3, 4, 4);
  }


}
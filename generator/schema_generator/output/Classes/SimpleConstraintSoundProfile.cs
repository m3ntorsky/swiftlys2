using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SimpleConstraintSoundProfile : SchemaClass, ISimpleConstraintSoundProfile {

  public SimpleConstraintSoundProfile(nint handle) : base(handle) {
  }

  public SimpleConstraintSoundProfile(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref SimpleConstraintSoundProfile::SimpleConstraintsSoundProfileKeypoints_t Keypoints {
    get => ref _Handle.AsRef<SimpleConstraintSoundProfile::SimpleConstraintsSoundProfileKeypoints_t>(Schema.GetOffset(0xB768AA94AE55150C));
  }
  public ISchemaFixedArray<float32> KeyPoints {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0xB768AA9449DA0463));
  }
  public ISchemaFixedArray<float32> ReversalSoundThresholds {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0xB768AA9405E06766));
  }


}
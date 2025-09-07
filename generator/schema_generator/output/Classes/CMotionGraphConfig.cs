using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionGraphConfig : SchemaClass, IMotionGraphConfig {

  public CMotionGraphConfig(nint handle) : base(handle) {
  }

  public CMotionGraphConfig(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<float32> ParamValues {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0x851F6EEA365BD3F8));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x851F6EEABC5E3BAB));
  }
  public IMotionIndex MotionIndex {
    get => new MotionIndex(_Handle + Schema.GetOffset(0x851F6EEABF50B8E1));
  }
  public ref int SampleStart {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x851F6EEA43384B19));
  }
  public ref int SampleCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x851F6EEA2DEF676A));
  }


}
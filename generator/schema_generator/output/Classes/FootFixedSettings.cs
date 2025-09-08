using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FootFixedSettings : SchemaClass, IFootFixedSettings {

  public FootFixedSettings(nint handle) : base(handle) {
  }

  public ITraceSettings_t TraceSettings {
    get => new TraceSettings_t(_Handle + Schema.GetOffset(0x3401F9D0115F2D3B));
  }
  public ref VectorAligned FootBaseBindPosePositionMS {
    get => ref _Handle.AsRef<VectorAligned>(Schema.GetOffset(0x3401F9D0C391A025));
  }
  public ref float FootBaseLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3401F9D08593ED7E));
  }
  public ref float MaxRotationLeft {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3401F9D0FA1CDF44));
  }
  public ref float MaxRotationRight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3401F9D08C95FA31));
  }
  public ref int FootstepLandedTagIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3401F9D04954321B));
  }
  public ref bool EnableTracing {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3401F9D03C16FC54));
  }
  public ref float TraceAngleBlend {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3401F9D0029B769E));
  }
  public ref int DisableTagIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3401F9D0C56AE9EB));
  }
  public ref int FootIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3401F9D067D56BAB));
  }


}
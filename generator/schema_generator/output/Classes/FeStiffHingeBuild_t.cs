using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeStiffHingeBuild_t : SchemaClass, IFeStiffHingeBuild_t {

  public FeStiffHingeBuild_t(nint handle) : base(handle) {
  }

  public FeStiffHingeBuild_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float MaxAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x41A81A5876FE0F8E));
  }
  public ref float Strength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x41A81A58AFA3323A));
  }
  public ISchemaFixedArray<float32> MotionBias {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0x41A81A582CDDBF14));
  }
  public ISchemaFixedArray<uint16> Node {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x41A81A58CD6694B9));
  }


}
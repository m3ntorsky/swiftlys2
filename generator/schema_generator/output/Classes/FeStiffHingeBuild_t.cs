using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeStiffHingeBuild_t : SchemaClass, IFeStiffHingeBuild_t {

  public FeStiffHingeBuild_t(nint handle) : base(handle) {
  }

  public ref float MaxAngle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x41A81A5876FE0F8E));
  }
  public ref float Strength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x41A81A58AFA3323A));
  }
  public ISchemaFixedArray<float> MotionBias {
    get => new SchemaFixedArray<float>(_Handle, 0x41A81A582CDDBF14, 3, 4, 4);
  }
  public ISchemaFixedArray<ushort> Node {
    get => new SchemaFixedArray<ushort>(_Handle, 0x41A81A58CD6694B9, 3, 2, 2);
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSimdAnimStrayRadius_t : SchemaClass, IFeSimdAnimStrayRadius_t {

  public FeSimdAnimStrayRadius_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<ushort[4]> Node {
    get => new SchemaFixedArray<ushort[4]>(_Handle, 0xEEC96A9CCD6694B9, 2, 8, 2);
  }
  public ref fltx4 MaxDist {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xEEC96A9CC9FFDD57));
  }
  public ref fltx4 RelaxationFactor {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xEEC96A9C357F3BFF));
  }


}
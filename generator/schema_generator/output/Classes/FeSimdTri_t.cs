using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSimdTri_t : SchemaClass, IFeSimdTri_t {

  public FeSimdTri_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<uint[4]> Node {
    get => new SchemaFixedArray<uint[4]>(_Handle, 0x1D57E70DCD6694B9, 3, 16, 4);
  }
  public ref fltx4 W1 {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x1D57E70D10473805));
  }
  public ref fltx4 W2 {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x1D57E70D0D47334C));
  }
  public ref fltx4 V1x {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x1D57E70D80EC4B30));
  }
  public ref FourVectors2D V2 {
    get => ref _Handle.AsRef<FourVectors2D>(Schema.GetOffset(0x1D57E70D974A4B21));
  }


}
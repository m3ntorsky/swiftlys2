using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FourVectors2D : SchemaClass, IFourVectors2D {

  public FourVectors2D(nint handle) : base(handle) {
  }

  public ref fltx4 X {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x7A817FA5FD0C5087));
  }
  public ref fltx4 Y {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x7A817FA5FC0C4EF4));
  }


}
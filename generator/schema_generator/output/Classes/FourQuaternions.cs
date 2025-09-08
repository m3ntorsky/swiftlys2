using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FourQuaternions : SchemaClass, IFourQuaternions {

  public FourQuaternions(nint handle) : base(handle) {
  }

  public ref fltx4 X {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x438DAD7AFD0C5087));
  }
  public ref fltx4 Y {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x438DAD7AFC0C4EF4));
  }
  public ref fltx4 Z {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x438DAD7AFF0C53AD));
  }
  public ref fltx4 W {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0x438DAD7AF20C3F36));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class Extent : SchemaClass, IExtent {

  public Extent(nint handle) : base(handle) {
  }

  public ref Vector Lo {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6E8BE8394231C06C));
  }
  public ref Vector Hi {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6E8BE839683AF69A));
  }


}
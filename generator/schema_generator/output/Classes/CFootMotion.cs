using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootMotion : SchemaClass, IFootMotion {

  public CFootMotion(nint handle) : base(handle) {
  }

  public ref CUtlVector Strides {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA4A598B8AE9C97F1));
  }
  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xA4A598B84D8F5786));
  }
  public ref bool Additive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA4A598B80FA86105));
  }


}
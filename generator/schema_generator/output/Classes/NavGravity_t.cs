using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class NavGravity_t : SchemaClass, INavGravity_t {

  public NavGravity_t(nint handle) : base(handle) {
  }

  public ref Vector Gravity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xAF45EC63A5AE4779));
  }
  public ref bool Default {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAF45EC6385F067BE));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CConstraintAnchor : CBaseAnimGraph, IConstraintAnchor {

  public CConstraintAnchor(nint handle) : base(handle) {
  }

  public ref float MassScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD8ABF41001B9E905));
  }


}
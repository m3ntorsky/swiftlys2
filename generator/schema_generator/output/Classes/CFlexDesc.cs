using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFlexDesc : SchemaClass, IFlexDesc {

  public CFlexDesc(nint handle) : base(handle) {
  }

  public ref CUtlString Facs {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xF8B9C4900514A8FF));
  }


}
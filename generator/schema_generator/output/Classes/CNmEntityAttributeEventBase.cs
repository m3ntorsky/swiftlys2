using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmEntityAttributeEventBase : CNmEvent, INmEntityAttributeEventBase {

  public CNmEntityAttributeEventBase(nint handle) : base(handle) {
  }

  public ref CUtlString AttributeName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x92D29AE99168F02C));
  }


}
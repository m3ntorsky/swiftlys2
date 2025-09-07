using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDynamicPropAlias_dynamic_prop : CDynamicProp, IDynamicPropAlias_dynamic_prop {

  public CDynamicPropAlias_dynamic_prop(nint handle) : base(handle) {
  }

  public CDynamicPropAlias_dynamic_prop(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}
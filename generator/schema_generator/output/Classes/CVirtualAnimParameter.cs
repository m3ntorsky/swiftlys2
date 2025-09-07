using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVirtualAnimParameter : CAnimParameterBase, IVirtualAnimParameter {

  public CVirtualAnimParameter(nint handle) : base(handle) {
  }

  public CVirtualAnimParameter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString ExpressionString {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x3D45915B3039426E));
  }
  public ref AnimParamType_t ParamType {
    get => ref _Handle.AsRef<AnimParamType_t>(Schema.GetOffset(0x3D45915BF05DFDD9));
  }


}
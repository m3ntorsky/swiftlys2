using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelConfigElement_SetMaterialGroup : CModelConfigElement, IModelConfigElement_SetMaterialGroup {

  public CModelConfigElement_SetMaterialGroup(nint handle) : base(handle) {
  }

  public CModelConfigElement_SetMaterialGroup(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString MaterialGroupName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xFF9AED50C2DD3048));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelConfigElement_SetMaterialGroupOnAttachedModels : CModelConfigElement, IModelConfigElement_SetMaterialGroupOnAttachedModels {

  public CModelConfigElement_SetMaterialGroupOnAttachedModels(nint handle) : base(handle) {
  }

  public CModelConfigElement_SetMaterialGroupOnAttachedModels(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString MaterialGroupName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xAD67B617C2DD3048));
  }


}
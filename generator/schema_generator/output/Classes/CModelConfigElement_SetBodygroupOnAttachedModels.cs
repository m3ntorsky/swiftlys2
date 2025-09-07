using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelConfigElement_SetBodygroupOnAttachedModels : CModelConfigElement, IModelConfigElement_SetBodygroupOnAttachedModels {

  public CModelConfigElement_SetBodygroupOnAttachedModels(nint handle) : base(handle) {
  }

  public CModelConfigElement_SetBodygroupOnAttachedModels(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString GroupName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xCC9BDB84E0A55E67));
  }
  public ref int Choice {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xCC9BDB847CC11192));
  }


}
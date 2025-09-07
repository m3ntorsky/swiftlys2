using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelConfigElement_UserPick : CModelConfigElement, IModelConfigElement_UserPick {

  public CModelConfigElement_UserPick(nint handle) : base(handle) {
  }

  public CModelConfigElement_UserPick(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CUtlString > Choices {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0x9AB617A69E9959BF));
  }


}
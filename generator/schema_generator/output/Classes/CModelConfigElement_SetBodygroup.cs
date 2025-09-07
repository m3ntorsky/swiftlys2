using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelConfigElement_SetBodygroup : CModelConfigElement, IModelConfigElement_SetBodygroup {

  public CModelConfigElement_SetBodygroup(nint handle) : base(handle) {
  }

  public CModelConfigElement_SetBodygroup(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CGlobalSymbol GroupName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x390A561FE0A55E67));
  }
  public ref int Choice {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x390A561F7CC11192));
  }


}
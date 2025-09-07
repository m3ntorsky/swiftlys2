using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterName : CBaseFilter, IFilterName {

  public CFilterName(nint handle) : base(handle) {
  }

  public CFilterName(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge FilterName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xF129410709C86445));
  }


}
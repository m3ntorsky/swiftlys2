using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterContext : CBaseFilter, IFilterContext {

  public CFilterContext(nint handle) : base(handle) {
  }

  public CFilterContext(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge FilterContext {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xA9DA7EEFF90438D1));
  }


}
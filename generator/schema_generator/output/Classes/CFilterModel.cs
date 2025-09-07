using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterModel : CBaseFilter, IFilterModel {

  public CFilterModel(nint handle) : base(handle) {
  }

  public CFilterModel(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge FilterModel {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x59DA03B921E36753));
  }


}
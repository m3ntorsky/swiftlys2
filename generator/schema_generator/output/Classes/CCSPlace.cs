using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlace : CServerOnlyModelEntity, ICSPlace {

  public CCSPlace(nint handle) : base(handle) {
  }

  public CCSPlace(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge Name {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x7AF35BE34D8F5786));
  }


}
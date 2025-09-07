using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SelectedEditItemInfo_t : SchemaClass, ISelectedEditItemInfo_t {

  public SelectedEditItemInfo_t(nint handle) : base(handle) {
  }

  public SelectedEditItemInfo_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< SosEditItemInfo_t > EditItems {
    get => ref _Handle.AsRef<CUtlVector< SosEditItemInfo_t >>(Schema.GetOffset(0xDF4D8E78F11EB01B));
  }


}
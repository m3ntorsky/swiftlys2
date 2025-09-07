using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PackedAABB_t : SchemaClass, IPackedAABB_t {

  public PackedAABB_t(nint handle) : base(handle) {
  }

  public PackedAABB_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint PackedMin {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x868E43307AC1AEAF));
  }
  public ref uint PackedMax {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x868E433068AE0AA1));
  }


}
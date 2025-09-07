using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class StanceInfo_t : SchemaClass, IStanceInfo_t {

  public StanceInfo_t(nint handle) : base(handle) {
  }

  public StanceInfo_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Position {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5DBAB98EBD6A6C9E));
  }
  public ref float Direction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5DBAB98E28D81988));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AutoRoomDoorwayPairs_t : SchemaClass, IAutoRoomDoorwayPairs_t {

  public AutoRoomDoorwayPairs_t(nint handle) : base(handle) {
  }

  public AutoRoomDoorwayPairs_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector P1 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x735A94BECD01805E));
  }
  public ref Vector P2 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x735A94BECC017ECB));
  }


}
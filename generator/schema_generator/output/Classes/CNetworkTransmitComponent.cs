using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNetworkTransmitComponent : SchemaClass, INetworkTransmitComponent {

  public CNetworkTransmitComponent(nint handle) : base(handle) {
  }

  public CNetworkTransmitComponent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref byte TransmitStateOwnedCounter {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x2D6BD23F6BC30751));
  }


}
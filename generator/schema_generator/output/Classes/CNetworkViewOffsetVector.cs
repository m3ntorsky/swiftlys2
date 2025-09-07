using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNetworkViewOffsetVector : SchemaClass, INetworkViewOffsetVector {

  public CNetworkViewOffsetVector(nint handle) : base(handle) {
  }

  public CNetworkViewOffsetVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CNetworkedQuantizedFloat X {
    get => ref _Handle.AsRef<CNetworkedQuantizedFloat>(Schema.GetOffset(0x178DD1B58FEB7867));
  }
  public ref CNetworkedQuantizedFloat Y {
    get => ref _Handle.AsRef<CNetworkedQuantizedFloat>(Schema.GetOffset(0x178DD1B58EEB76D4));
  }
  public ref CNetworkedQuantizedFloat Z {
    get => ref _Handle.AsRef<CNetworkedQuantizedFloat>(Schema.GetOffset(0x178DD1B591EB7B8D));
  }

  public void XUpdated() {
    Schema.Update(_Handle, 0x178DD1B58FEB7867);
  }
  public void YUpdated() {
    Schema.Update(_Handle, 0x178DD1B58EEB76D4);
  }
  public void ZUpdated() {
    Schema.Update(_Handle, 0x178DD1B591EB7B8D);
  }
}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeAntiTunnelGroupBuild_t : SchemaClass, IFeAntiTunnelGroupBuild_t {

  public FeAntiTunnelGroupBuild_t(nint handle) : base(handle) {
  }

  public FeAntiTunnelGroupBuild_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref uint VertexMapHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x8189225C06BCA0A3));
  }
  public ref uint CollisionMask {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x8189225C0CCF1BEF));
  }


}
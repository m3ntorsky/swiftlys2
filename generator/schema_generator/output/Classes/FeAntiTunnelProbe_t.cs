using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeAntiTunnelProbe_t : SchemaClass, IFeAntiTunnelProbe_t {

  public FeAntiTunnelProbe_t(nint handle) : base(handle) {
  }

  public FeAntiTunnelProbe_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBC54CE0BCFFC66CB));
  }
  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xBC54CE0BB8D52E48));
  }
  public ref ushort ProbeNode {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xBC54CE0B5F3CB12D));
  }
  public ref ushort Count {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xBC54CE0B67983E28));
  }
  public ref uint Begin {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xBC54CE0BC630D75A));
  }
  public ref float ActivationDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBC54CE0BEAB1A998));
  }
  public ref float CurvatureRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBC54CE0BADAE92BE));
  }
  public ref float Bias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBC54CE0B30667CD6));
  }


}
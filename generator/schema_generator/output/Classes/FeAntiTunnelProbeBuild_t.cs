using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeAntiTunnelProbeBuild_t : SchemaClass, IFeAntiTunnelProbeBuild_t {

  public FeAntiTunnelProbeBuild_t(nint handle) : base(handle) {
  }

  public FeAntiTunnelProbeBuild_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x71B6F8ABCFFC66CB));
  }
  public ref float ActivationDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x71B6F8ABEAB1A998));
  }
  public ref float Bias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x71B6F8AB30667CD6));
  }
  public ref float Curvature {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x71B6F8ABF5F69668));
  }
  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x71B6F8ABB8D52E48));
  }
  public ref ushort ProbeNode {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x71B6F8AB5F3CB12D));
  }
  public ref CUtlVector< uint16 > TargetNodes {
    get => ref _Handle.AsRef<CUtlVector< uint16 >>(Schema.GetOffset(0x71B6F8AB4BCFFCA5));
  }


}
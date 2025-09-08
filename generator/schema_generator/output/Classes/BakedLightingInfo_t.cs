using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class BakedLightingInfo_t : SchemaClass, IBakedLightingInfo_t {

  public BakedLightingInfo_t(nint handle) : base(handle) {
  }

  public ref uint LightmapVersionNumber {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x6909F4EF909450E0));
  }
  public ref uint LightmapGameVersionNumber {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x6909F4EFC1181112));
  }
  public ref Vector2D LightmapUvScale {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0x6909F4EF36320516));
  }
  public ref bool HasLightmaps {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6909F4EF86932F1E));
  }
  public ref bool BakedShadowsGamma20 {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6909F4EF2FA903D4));
  }
  public ref bool CompressionEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6909F4EF0082912E));
  }
  public ref bool SHLightmaps {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6909F4EF04697DAD));
  }
  public ref byte ChartPackIterations {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x6909F4EF7CF370A6));
  }
  public ref byte VradQuality {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x6909F4EFDFCA05D9));
  }
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeCTextureBase>> LightMaps {
    get => ref _Handle.AsRef<CUtlVector<CStrongHandle<InfoForResourceTypeCTextureBase>>>(Schema.GetOffset(0x6909F4EF6F2EFF94));
  }
  public ref CUtlVector BakedShadows {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x6909F4EFE8C9B481));
  }


}
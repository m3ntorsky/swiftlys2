using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RenderProjectedMaterial_t : SchemaClass, IRenderProjectedMaterial_t {

  public RenderProjectedMaterial_t(nint handle) : base(handle) {
  }

  public RenderProjectedMaterial_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CStrongHandle< InfoForResourceTypeIMaterial2 > Material {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeIMaterial2 >>(Schema.GetOffset(0x62AF09D5888CE42E));
  }


}
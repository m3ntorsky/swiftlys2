using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RenderProjectedMaterial_t : SchemaClass, IRenderProjectedMaterial_t {

  public RenderProjectedMaterial_t(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeIMaterial2> Material {
    get => new CStrongHandle<InfoForResourceTypeIMaterial2>(_Handle + Schema.GetOffset(0x62AF09D5888CE42E));
  }


}
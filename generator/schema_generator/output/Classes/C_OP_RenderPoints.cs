using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderPoints : CParticleFunctionRenderer, IC_OP_RenderPoints {

  public C_OP_RenderPoints(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeIMaterial2> Material {
    get => new CStrongHandle<InfoForResourceTypeIMaterial2>(_Handle + Schema.GetOffset(0x9B246DAE888CE42E));
  }


}
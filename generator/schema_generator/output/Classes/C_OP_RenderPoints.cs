using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderPoints : CParticleFunctionRenderer, IC_OP_RenderPoints {

  public C_OP_RenderPoints(nint handle) : base(handle) {
  }

  public ref CStrongHandle<InfoForResourceTypeIMaterial2> Material {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIMaterial2>>(Schema.GetOffset(0x9B246DAE888CE42E));
  }


}
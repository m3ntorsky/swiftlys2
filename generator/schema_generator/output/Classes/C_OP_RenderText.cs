using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderText : CParticleFunctionRenderer, IC_OP_RenderText {

  public C_OP_RenderText(nint handle) : base(handle) {
  }

  public ref Color OutlineColor {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x376BB2E675B94BB0));
  }
  public ref CUtlString DefaultText {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x376BB2E67556AF5D));
  }


}
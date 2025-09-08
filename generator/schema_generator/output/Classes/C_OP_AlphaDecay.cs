using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_AlphaDecay : CParticleFunctionOperator, IC_OP_AlphaDecay {

  public C_OP_AlphaDecay(nint handle) : base(handle) {
  }

  public ref float MinAlpha {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x26EE2FFBEC24C4FF));
  }


}
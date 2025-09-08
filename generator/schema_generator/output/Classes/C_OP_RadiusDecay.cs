using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RadiusDecay : CParticleFunctionOperator, IC_OP_RadiusDecay {

  public C_OP_RadiusDecay(nint handle) : base(handle) {
  }

  public ref float MinRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x119375431D07C7B7));
  }


}
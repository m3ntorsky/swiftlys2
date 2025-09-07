using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_Decay : CParticleFunctionOperator, IC_OP_Decay {

  public C_OP_Decay(nint handle) : base(handle) {
  }

  public C_OP_Decay(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool RopeDecay {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9342606D2A5D2225));
  }
  public ref bool ForcePreserveParticleOrder {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9342606DFEB98B86));
  }


}
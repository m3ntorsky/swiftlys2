using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_VelocityDecay : CParticleFunctionOperator, IC_OP_VelocityDecay {

  public C_OP_VelocityDecay(nint handle) : base(handle) {
  }

  public C_OP_VelocityDecay(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float MinVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF59EE920AE8F0ADE));
  }


}
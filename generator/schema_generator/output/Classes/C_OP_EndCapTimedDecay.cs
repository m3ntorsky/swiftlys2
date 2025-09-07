using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_EndCapTimedDecay : CParticleFunctionOperator, IC_OP_EndCapTimedDecay {

  public C_OP_EndCapTimedDecay(nint handle) : base(handle) {
  }

  public C_OP_EndCapTimedDecay(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float DecayTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2866C865E94A0656));
  }


}
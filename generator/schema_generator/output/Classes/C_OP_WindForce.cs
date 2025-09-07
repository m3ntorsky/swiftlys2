using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_WindForce : CParticleFunctionForce, IC_OP_WindForce {

  public C_OP_WindForce(nint handle) : base(handle) {
  }

  public C_OP_WindForce(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Force {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xBBD251C2E530B0A8));
  }


}
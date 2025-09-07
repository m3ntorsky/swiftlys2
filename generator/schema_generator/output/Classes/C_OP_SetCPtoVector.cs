using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetCPtoVector : CParticleFunctionOperator, IC_OP_SetCPtoVector {

  public C_OP_SetCPtoVector(nint handle) : base(handle) {
  }

  public C_OP_SetCPtoVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CPInput {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x799E4536FB805736));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x799E4536E5729606));
  }


}
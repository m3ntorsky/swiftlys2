using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LerpEndCapVector : CParticleFunctionOperator, IC_OP_LerpEndCapVector {

  public C_OP_LerpEndCapVector(nint handle) : base(handle) {
  }

  public C_OP_LerpEndCapVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4847E160E5729606));
  }
  public ref Vector Output {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4847E16008B7FF64));
  }
  public ref float LerpTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4847E16054FD987F));
  }


}
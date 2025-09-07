using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_LerpScalar : CParticleFunctionOperator, IC_OP_LerpScalar {

  public C_OP_LerpScalar(nint handle) : base(handle) {
  }

  public C_OP_LerpScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xB2C648D4E5729606));
  }
  public IPerParticleFloatInput Output {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xB2C648D4368F96A2));
  }
  public ref float StartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB2C648D467FE9DC4));
  }
  public ref float EndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB2C648D42041DF9D));
  }


}
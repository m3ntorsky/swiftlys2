using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ReadFromNeighboringParticle : CParticleFunctionOperator, IC_OP_ReadFromNeighboringParticle {

  public C_OP_ReadFromNeighboringParticle(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xDC4AE427AE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xDC4AE427E5729606));
  }
  public ref int Increment {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDC4AE4272359F182));
  }
  public IPerParticleFloatInput DistanceCheck {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xDC4AE4272F031DC2));
  }
  public IPerParticleFloatInput Interpolation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xDC4AE427CF55B987));
  }


}
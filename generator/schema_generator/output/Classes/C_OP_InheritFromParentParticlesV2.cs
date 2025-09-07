using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_InheritFromParentParticlesV2 : CParticleFunctionOperator, IC_OP_InheritFromParentParticlesV2 {

  public C_OP_InheritFromParentParticlesV2(nint handle) : base(handle) {
  }

  public C_OP_InheritFromParentParticlesV2(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput Scale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xF948CFAFB731A42F));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF948CFAFE5729606));
  }
  public IPerParticleFloatInput Increment {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xF948CFAF2359F182));
  }
  public ref bool RandomDistribution {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF948CFAF830F6B38));
  }
  public ref bool Reverse {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF948CFAFEA4E22E5));
  }
  public ref MissingParentInheritBehavior_t MissingParentBehavior {
    get => ref _Handle.AsRef<MissingParentInheritBehavior_t>(Schema.GetOffset(0xF948CFAF9B0F277D));
  }
  public IPerParticleFloatInput Interpolation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xF948CFAFCF55B987));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_DistanceBetweenVecs : CParticleFunctionOperator, IC_OP_DistanceBetweenVecs {

  public C_OP_DistanceBetweenVecs(nint handle) : base(handle) {
  }

  public C_OP_DistanceBetweenVecs(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xA94A9A29E5729606));
  }
  public IPerParticleVecInput Point1 {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xA94A9A2904AD2BC0));
  }
  public IPerParticleVecInput Point2 {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xA94A9A2907AD3079));
  }
  public IPerParticleFloatInput InputMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA94A9A29E88A0D0F));
  }
  public IPerParticleFloatInput InputMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA94A9A29D6766901));
  }
  public IPerParticleFloatInput OutputMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA94A9A295F8D7716));
  }
  public IPerParticleFloatInput OutputMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA94A9A2951A0E8C4));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0xA94A9A29FB53C31E));
  }
  public ref bool DeltaTime {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA94A9A29464DB858));
  }


}
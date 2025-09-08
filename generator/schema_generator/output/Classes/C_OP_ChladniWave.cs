using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ChladniWave : CParticleFunctionOperator, IC_OP_ChladniWave {

  public C_OP_ChladniWave(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x5C575E1BE5729606));
  }
  public IPerParticleFloatInput InputMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x5C575E1BE88A0D0F));
  }
  public IPerParticleFloatInput InputMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x5C575E1BD6766901));
  }
  public IPerParticleFloatInput OutputMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x5C575E1B5F8D7716));
  }
  public IPerParticleFloatInput OutputMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x5C575E1B51A0E8C4));
  }
  public IPerParticleVecInput WaveLength {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x5C575E1B33948038));
  }
  public IPerParticleVecInput Harmonics {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x5C575E1B91D6B17F));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x5C575E1BFB53C31E));
  }
  public ref int LocalSpaceControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5C575E1B1656DBF7));
  }
  public ref bool B3D {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5C575E1B24E1BE32));
  }


}
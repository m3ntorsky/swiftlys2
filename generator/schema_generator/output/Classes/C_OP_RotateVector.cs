using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RotateVector : CParticleFunctionOperator, IC_OP_RotateVector {

  public C_OP_RotateVector(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x43DEF471E5729606));
  }
  public ref Vector RotAxisMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x43DEF471E51ED175));
  }
  public ref Vector RotAxisMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x43DEF471CF32368B));
  }
  public ref float RotRateMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x43DEF4710EE55F62));
  }
  public ref float RotRateMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x43DEF471F8D1B508));
  }
  public ref bool Normalize {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x43DEF47148BC424C));
  }
  public IPerParticleFloatInput Scale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x43DEF471B731A42F));
  }


}
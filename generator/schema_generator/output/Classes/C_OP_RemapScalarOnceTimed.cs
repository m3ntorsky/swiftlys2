using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapScalarOnceTimed : CParticleFunctionOperator, IC_OP_RemapScalarOnceTimed {

  public C_OP_RemapScalarOnceTimed(nint handle) : base(handle) {
  }

  public ref bool Proportional {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF5150932891F328A));
  }
  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF5150932AE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF5150932E5729606));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF5150932E88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF5150932D6766901));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF51509325F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF515093251A0E8C4));
  }
  public ref float RemapTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF5150932F436AC39));
  }


}
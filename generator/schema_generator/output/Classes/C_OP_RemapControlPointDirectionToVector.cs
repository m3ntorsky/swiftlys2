using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapControlPointDirectionToVector : CParticleFunctionOperator, IC_OP_RemapControlPointDirectionToVector {

  public C_OP_RemapControlPointDirectionToVector(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xB5467A62E5729606));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB5467A62B731A42F));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB5467A623F31A6BD));
  }


}
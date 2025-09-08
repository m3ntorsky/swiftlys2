using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapVelocityToVector : CParticleFunctionOperator, IC_OP_RemapVelocityToVector {

  public C_OP_RemapVelocityToVector(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x3985F683E5729606));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3985F683B731A42F));
  }
  public ref bool Normalize {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3985F68348BC424C));
  }


}
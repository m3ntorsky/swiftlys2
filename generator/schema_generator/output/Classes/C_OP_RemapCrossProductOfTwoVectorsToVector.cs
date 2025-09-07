using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapCrossProductOfTwoVectorsToVector : CParticleFunctionOperator, IC_OP_RemapCrossProductOfTwoVectorsToVector {

  public C_OP_RemapCrossProductOfTwoVectorsToVector(nint handle) : base(handle) {
  }

  public C_OP_RemapCrossProductOfTwoVectorsToVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleVecInput InputVec1 {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x4B4531D84584355A));
  }
  public IPerParticleVecInput InputVec2 {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x4B4531D8448433C7));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4B4531D8E5729606));
  }
  public ref bool Normalize {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4B4531D848BC424C));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetFloatAttributeToVectorExpression : CParticleFunctionOperator, IC_OP_SetFloatAttributeToVectorExpression {

  public C_OP_SetFloatAttributeToVectorExpression(nint handle) : base(handle) {
  }

  public ref VectorFloatExpressionType_t Expression {
    get => ref _Handle.AsRef<VectorFloatExpressionType_t>(Schema.GetOffset(0x26D81D160B2427));
  }
  public IPerParticleVecInput Input1 {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x26D81DE17F27DA));
  }
  public IPerParticleVecInput Input2 {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x26D81DE07F2647));
  }
  public IParticleRemapFloatInput OutputRemap {
    get => new CParticleRemapFloatInput(_Handle + Schema.GetOffset(0x26D81D1239396F));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x26D81D324F6F74));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x26D81DFB53C31E));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetVectorAttributeToVectorExpression : CParticleFunctionOperator, IC_OP_SetVectorAttributeToVectorExpression {

  public C_OP_SetVectorAttributeToVectorExpression(nint handle) : base(handle) {
  }

  public ref VectorExpressionType_t Expression {
    get => ref _Handle.AsRef<VectorExpressionType_t>(Schema.GetOffset(0xF36D0C4160B2427));
  }
  public IPerParticleVecInput Input1 {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xF36D0C4E17F27DA));
  }
  public IPerParticleVecInput Input2 {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xF36D0C4E07F2647));
  }
  public IPerParticleFloatInput Lerp {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xF36D0C4622FAB06));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF36D0C4324F6F74));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0xF36D0C4FB53C31E));
  }
  public ref bool NormalizedOutput {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF36D0C40AA98C55));
  }


}
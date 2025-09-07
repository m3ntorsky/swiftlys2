using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetAttributeToScalarExpression : CParticleFunctionOperator, IC_OP_SetAttributeToScalarExpression {

  public C_OP_SetAttributeToScalarExpression(nint handle) : base(handle) {
  }

  public C_OP_SetAttributeToScalarExpression(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ScalarExpressionType_t Expression {
    get => ref _Handle.AsRef<ScalarExpressionType_t>(Schema.GetOffset(0x3D6339D6160B2427));
  }
  public IPerParticleFloatInput Input1 {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x3D6339D6E9DA2E24));
  }
  public IPerParticleFloatInput Input2 {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x3D6339D6ECDA32DD));
  }
  public IParticleRemapFloatInput OutputRemap {
    get => new CParticleRemapFloatInput(_Handle + Schema.GetOffset(0x3D6339D61239396F));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x3D6339D6324F6F74));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x3D6339D6FB53C31E));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_SetAttributeToScalarExpression : CParticleFunctionInitializer, IC_INIT_SetAttributeToScalarExpression {

  public C_INIT_SetAttributeToScalarExpression(nint handle) : base(handle) {
  }

  public C_INIT_SetAttributeToScalarExpression(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ScalarExpressionType_t Expression {
    get => ref _Handle.AsRef<ScalarExpressionType_t>(Schema.GetOffset(0x7B168019160B2427));
  }
  public IPerParticleFloatInput Input1 {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x7B168019E9DA2E24));
  }
  public IPerParticleFloatInput Input2 {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x7B168019ECDA32DD));
  }
  public IParticleRemapFloatInput OutputRemap {
    get => new CParticleRemapFloatInput(_Handle + Schema.GetOffset(0x7B1680191239396F));
  }
  public IParticleAttributeIndex_t OutputField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x7B168019324F6F74));
  }
  public ref ParticleSetMethod_t SetMethod {
    get => ref _Handle.AsRef<ParticleSetMethod_t>(Schema.GetOffset(0x7B168019FB53C31E));
  }


}
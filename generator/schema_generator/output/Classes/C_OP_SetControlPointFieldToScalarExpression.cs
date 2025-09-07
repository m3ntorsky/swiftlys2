using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointFieldToScalarExpression : CParticleFunctionPreEmission, IC_OP_SetControlPointFieldToScalarExpression {

  public C_OP_SetControlPointFieldToScalarExpression(nint handle) : base(handle) {
  }

  public C_OP_SetControlPointFieldToScalarExpression(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ScalarExpressionType_t Expression {
    get => ref _Handle.AsRef<ScalarExpressionType_t>(Schema.GetOffset(0x6A8A3411160B2427));
  }
  public IParticleCollectionFloatInput Input1 {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x6A8A3411E9DA2E24));
  }
  public IParticleCollectionFloatInput Input2 {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x6A8A3411ECDA32DD));
  }
  public IParticleRemapFloatInput OutputRemap {
    get => new CParticleRemapFloatInput(_Handle + Schema.GetOffset(0x6A8A34111239396F));
  }
  public ref int OutputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6A8A341150DF5703));
  }
  public ref int OutVectorField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6A8A3411F9041E74));
  }


}
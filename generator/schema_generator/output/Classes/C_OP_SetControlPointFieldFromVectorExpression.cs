using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointFieldFromVectorExpression : CParticleFunctionPreEmission, IC_OP_SetControlPointFieldFromVectorExpression {

  public C_OP_SetControlPointFieldFromVectorExpression(nint handle) : base(handle) {
  }

  public C_OP_SetControlPointFieldFromVectorExpression(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref VectorFloatExpressionType_t Expression {
    get => ref _Handle.AsRef<VectorFloatExpressionType_t>(Schema.GetOffset(0x1A9FFD07160B2427));
  }
  public IParticleCollectionVecInput Input1 {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x1A9FFD07A155BDDE));
  }
  public IParticleCollectionVecInput Input2 {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x1A9FFD07A055BC4B));
  }
  public IPerParticleFloatInput Lerp {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x1A9FFD07622FAB06));
  }
  public IParticleRemapFloatInput OutputRemap {
    get => new CParticleRemapFloatInput(_Handle + Schema.GetOffset(0x1A9FFD071239396F));
  }
  public ref int OutputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1A9FFD0750DF5703));
  }
  public ref int OutVectorField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1A9FFD07F9041E74));
  }


}
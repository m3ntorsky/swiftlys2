using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointToVectorExpression : CParticleFunctionPreEmission, IC_OP_SetControlPointToVectorExpression {

  public C_OP_SetControlPointToVectorExpression(nint handle) : base(handle) {
  }

  public C_OP_SetControlPointToVectorExpression(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref VectorExpressionType_t Expression {
    get => ref _Handle.AsRef<VectorExpressionType_t>(Schema.GetOffset(0x67E9EFDE160B2427));
  }
  public ref int OutputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x67E9EFDE50DF5703));
  }
  public IParticleCollectionVecInput Input1 {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x67E9EFDEE17F27DA));
  }
  public IParticleCollectionVecInput Input2 {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x67E9EFDEE07F2647));
  }
  public IPerParticleFloatInput Lerp {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x67E9EFDE622FAB06));
  }
  public ref bool NormalizedOutput {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x67E9EFDE0AA98C55));
  }


}
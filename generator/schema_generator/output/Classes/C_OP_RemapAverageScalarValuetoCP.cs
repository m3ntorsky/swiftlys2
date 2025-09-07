using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapAverageScalarValuetoCP : CParticleFunctionPreEmission, IC_OP_RemapAverageScalarValuetoCP {

  public C_OP_RemapAverageScalarValuetoCP(nint handle) : base(handle) {
  }

  public C_OP_RemapAverageScalarValuetoCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref SetStatisticExpressionType_t Expression {
    get => ref _Handle.AsRef<SetStatisticExpressionType_t>(Schema.GetOffset(0x98EDCBBC160B2427));
  }
  public IParticleCollectionFloatInput DecimalPlaces {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x98EDCBBCB314ED06));
  }
  public ref int OutControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x98EDCBBCD021D73F));
  }
  public ref int OutVectorField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x98EDCBBCF9041E74));
  }
  public IParticleAttributeIndex_t Field {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x98EDCBBCC257B93B));
  }
  public IParticleRemapFloatInput OutputRemap {
    get => new CParticleRemapFloatInput(_Handle + Schema.GetOffset(0x98EDCBBC1239396F));
  }


}
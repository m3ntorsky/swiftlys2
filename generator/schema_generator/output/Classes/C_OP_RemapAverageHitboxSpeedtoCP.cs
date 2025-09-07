using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapAverageHitboxSpeedtoCP : CParticleFunctionPreEmission, IC_OP_RemapAverageHitboxSpeedtoCP {

  public C_OP_RemapAverageHitboxSpeedtoCP(nint handle) : base(handle) {
  }

  public C_OP_RemapAverageHitboxSpeedtoCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int InControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE6055FBCE7CB99DE));
  }
  public ref int OutControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE6055FBCD021D73F));
  }
  public ref int Field {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE6055FBCC257B93B));
  }
  public ref ParticleHitboxDataSelection_t HitboxDataType {
    get => ref _Handle.AsRef<ParticleHitboxDataSelection_t>(Schema.GetOffset(0xE6055FBCAB1666E3));
  }
  public IParticleCollectionFloatInput InputMin {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xE6055FBCE88A0D0F));
  }
  public IParticleCollectionFloatInput InputMax {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xE6055FBCD6766901));
  }
  public IParticleCollectionFloatInput OutputMin {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xE6055FBC5F8D7716));
  }
  public IParticleCollectionFloatInput OutputMax {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xE6055FBC51A0E8C4));
  }
  public ref int HeightControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE6055FBCF2D4BC82));
  }
  public IParticleCollectionVecInput ComparisonVelocity {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xE6055FBC23BF409F));
  }
  public ISchemaFixedString HitboxSetName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xE6055FBC6A21BB0E));
  }


}
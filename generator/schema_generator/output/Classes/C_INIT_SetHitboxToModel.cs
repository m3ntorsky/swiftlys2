using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_SetHitboxToModel : CParticleFunctionInitializer, IC_INIT_SetHitboxToModel {

  public C_INIT_SetHitboxToModel(nint handle) : base(handle) {
  }

  public C_INIT_SetHitboxToModel(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7129E7BA3F31A6BD));
  }
  public ref int ForceInModel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7129E7BAA3C747AC));
  }
  public ref bool EvenDistribution {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7129E7BA84932067));
  }
  public ref int DesiredHitbox {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7129E7BAFD09531B));
  }
  public IParticleCollectionVecInput HitBoxScale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x7129E7BA58EE3FB7));
  }
  public ref Vector DirectionBias {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x7129E7BA5A1697CF));
  }
  public ref bool MaintainHitbox {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7129E7BAF2061926));
  }
  public ref bool UseBones {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7129E7BA10D1938B));
  }
  public ISchemaFixedString HitboxSetName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x7129E7BA6A21BB0E));
  }
  public IParticleCollectionFloatInput ShellSize {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x7129E7BA04D01B22));
  }


}
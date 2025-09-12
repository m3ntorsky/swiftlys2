using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvExplosion : CModelPointEntity, IEnvExplosion {

  public CEnvExplosion(nint handle) : base(handle) {
  }

  public ref int Magnitude {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x27411F012CBE4C2));
  }
  public ref float PlayerDamage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x27411F08C95143B));
  }
  public ref int RadiusOverride {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x27411F0CD5417B2));
  }
  public ref float InnerRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x27411F032121407));
  }
  public ref float DamageForce {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x27411F0AB66D0A5));
  }
  public ref CHandle<CBaseEntity> Inflictor {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x27411F04D7B4137));
  }
  public ref DamageTypes_t CustomDamageType {
    get => ref _Handle.AsRef<DamageTypes_t>(Schema.GetOffset(0x27411F0E0A58F6E));
  }
  public ref bool CreateDebris {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x27411F08F0AE362));
  }
  public ISchemaUntypedField CustomEffectName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x27411F0455090C0));
  }
  public ISchemaUntypedField CustomSoundName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x27411F0876FC976));
  }
  public ref bool SuppressParticleImpulse {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x27411F02C7847BB));
  }
  public ref Class_T ClassIgnore {
    get => ref _Handle.AsRef<Class_T>(Schema.GetOffset(0x27411F0A0290EDE));
  }
  public ref Class_T ClassIgnore2 {
    get => ref _Handle.AsRef<Class_T>(Schema.GetOffset(0x27411F00CA27D84));
  }
  public ISchemaUntypedField EntityIgnoreName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x27411F0A786C06F));
  }
  public ref CHandle<CBaseEntity> EntityIgnore {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x27411F08F1E5202));
  }


}
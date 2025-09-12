using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysExplosion : CPointEntity, IPhysExplosion {

  public CPhysExplosion(nint handle) : base(handle) {
  }

  public ref bool ExplodeOnSpawn {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xACEBD741D4BEFD5A));
  }
  public ref float Magnitude {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xACEBD741ED0A1D8B));
  }
  public ref float Damage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xACEBD741DC60E53E));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xACEBD741A921CA53));
  }
  public ISchemaUntypedField TargetEntityName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xACEBD741F88EC878));
  }
  public ref float InnerRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xACEBD74132121407));
  }
  public ref float PushScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xACEBD741BC279223));
  }
  public ref bool ConvertToDebrisWhenPossible {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xACEBD7416AD4D155));
  }
  public ref bool AffectInvulnerableEnts {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xACEBD74196CF6FA5));
  }
  public IEntityIOOutput OnPushedPlayer {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xACEBD74165C28180));
  }


}
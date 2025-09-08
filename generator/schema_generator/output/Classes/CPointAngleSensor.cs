using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointAngleSensor : CPointEntity, IPointAngleSensor {

  public CPointAngleSensor(nint handle) : base(handle) {
  }

  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1E4356013A7C5965));
  }
  public ref CUtlSymbolLarge LookAtName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1E435601A28C338C));
  }
  public ref CHandle<CBaseEntity> TargetEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x1E43560125D042A9));
  }
  public ref CHandle<CBaseEntity> LookAtEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x1E435601073CB5DE));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1E435601BC5E3BAB));
  }
  public ref float DotTolerance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1E4356011A15A535));
  }
  public IGameTime_t FacingTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1E43560177B926C8));
  }
  public ref bool Fired {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1E435601E8E73267));
  }
  public IEntityIOOutput OnFacingLookat {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1E4356011F71721C));
  }
  public IEntityIOOutput OnNotFacingLookat {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1E435601A7B496D5));
  }
  public ISchemaUntypedField TargetDir {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1E435601946F7FDF));
  }
  public ISchemaUntypedField FacingPercentage {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1E4356018B451097));
  }


}
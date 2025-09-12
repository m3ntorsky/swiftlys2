using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundEventEntity : CBaseEntity, ISoundEventEntity {

  public CSoundEventEntity(nint handle) : base(handle) {
  }

  public ref bool StartOnSpawn {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x85BC270CDB2E6401));
  }
  public ref bool ToLocalPlayer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x85BC270CE46A0E6E));
  }
  public ref bool StopOnNew {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x85BC270C87CBD5EE));
  }
  public ref bool SaveRestore {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x85BC270C329D644A));
  }
  public ref bool SavedIsPlaying {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x85BC270CE283DF5A));
  }
  public ref float SavedElapsedTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x85BC270C581DEF93));
  }
  public ISchemaUntypedField SourceEntityName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x85BC270C6C1387C0));
  }
  public ISchemaUntypedField AttachmentName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x85BC270C667A37F3));
  }
  public ISchemaUntypedField OnGUIDChanged {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x85BC270C2173B7A3));
  }
  public IEntityIOOutput OnSoundFinished {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x85BC270C35E97239));
  }
  public ref float ClientCullRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x85BC270CEC099542));
  }
  public ISchemaUntypedField SoundName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x85BC270CB17EB157));
  }
  public ref CHandle<IEntityInstance> Source {
    get => ref _Handle.AsRef<CHandle<IEntityInstance>>(Schema.GetOffset(0x85BC270C33D3CD82));
  }
  public ref int EntityIndexSelection {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x85BC270CD23B423C));
  }


}
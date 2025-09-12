using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvSoundscape : CBaseEntity, IEnvSoundscape {

  public CEnvSoundscape(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnPlay {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x4C8F896A5C0BA6F2));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4C8F896A5ACFC08D));
  }
  public ISchemaUntypedField SoundEventName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x4C8F896AABB0F687));
  }
  public ref bool OverrideWithEvent {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4C8F896A3DF1E5DB));
  }
  public ref int SoundscapeIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4C8F896A08B091CE));
  }
  public ref int SoundscapeEntityListId {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4C8F896A4F4663F0));
  }
  public ISchemaUntypedField PositionNames {
    get => new SchemaUntypedField(_Handle, 0x4C8F896A53DB5F86, 8, 8, 8);
  }
  public ref CHandle<CEnvSoundscape> ProxySoundscape {
    get => ref _Handle.AsRef<CHandle<CEnvSoundscape>>(Schema.GetOffset(0x4C8F896ABC23786E));
  }
  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4C8F896A3A7C5965));
  }
  public ISchemaUntypedField SoundscapeName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x4C8F896ABBF7AD61));
  }
  public ref uint SoundEventHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x4C8F896AC126D1EC));
  }


}
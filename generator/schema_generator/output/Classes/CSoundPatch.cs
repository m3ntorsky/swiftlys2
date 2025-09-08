using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundPatch : SchemaClass, ISoundPatch {

  public CSoundPatch(nint handle) : base(handle) {
  }

  public ISoundEnvelope Pitch {
    get => new CSoundEnvelope(_Handle + Schema.GetOffset(0xBE66ED3D12AC36D1));
  }
  public ISoundEnvelope Volume {
    get => new CSoundEnvelope(_Handle + Schema.GetOffset(0xBE66ED3DE3962F2F));
  }
  public ref float ShutdownTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBE66ED3DFA135362));
  }
  public ref float LastTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBE66ED3D2E79549E));
  }
  public ref CUtlSymbolLarge SoundScriptName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xBE66ED3D6486B844));
  }
  public ref CHandle<CBaseEntity> Ent {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xBE66ED3D8BBDB334));
  }
  public ref CEntityIndex SoundEntityIndex {
    get => ref _Handle.AsRef<CEntityIndex>(Schema.GetOffset(0xBE66ED3DEC098195));
  }
  public ref Vector SoundOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xBE66ED3D384D083E));
  }
  public ref int IsPlaying {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBE66ED3D71CADDE5));
  }
  public ICopyRecipientFilter Filter {
    get => new CCopyRecipientFilter(_Handle + Schema.GetOffset(0xBE66ED3D368220F7));
  }
  public ref float CloseCaptionDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBE66ED3D71B7507D));
  }
  public ref bool UpdatedSoundOrigin {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBE66ED3DACCF22F1));
  }
  public ref CUtlSymbolLarge ClassName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xBE66ED3D71BB2314));
  }


}
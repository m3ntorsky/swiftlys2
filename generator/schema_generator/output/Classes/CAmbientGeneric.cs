using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAmbientGeneric : CPointEntity, IAmbientGeneric {

  public CAmbientGeneric(nint handle) : base(handle) {
  }

  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD45BE96FA921CA53));
  }
  public ref float MaxRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD45BE96F89E61C15));
  }
  public ref soundlevel_t SoundLevel {
    get => ref _Handle.AsRef<soundlevel_t>(Schema.GetOffset(0xD45BE96FB69D19BB));
  }
  public Idynpitchvol_t Dpv {
    get => new dynpitchvol_t(_Handle + Schema.GetOffset(0xD45BE96FD7C5AFFD));
  }
  public ref bool Active {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD45BE96FC4EB465B));
  }
  public ref bool Looping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD45BE96F4FEBC8C1));
  }
  public ref CUtlSymbolLarge Sound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xD45BE96F5FF1867C));
  }
  public ref CUtlSymbolLarge SourceEntName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xD45BE96F2FABBF97));
  }
  public CHandle<IBaseEntity> SoundSource {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0xD45BE96FA2036C43));
  }
  public ref CEntityIndex SoundSourceEntIndex {
    get => ref _Handle.AsRef<CEntityIndex>(Schema.GetOffset(0xD45BE96F5C1CB026));
  }


}
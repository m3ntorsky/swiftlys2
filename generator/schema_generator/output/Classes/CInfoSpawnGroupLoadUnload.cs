using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInfoSpawnGroupLoadUnload : CLogicalEntity, IInfoSpawnGroupLoadUnload {

  public CInfoSpawnGroupLoadUnload(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnSpawnGroupLoadStarted {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x2537640F52B8B787));
  }
  public IEntityIOOutput OnSpawnGroupLoadFinished {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x2537640FF5DA3EA8));
  }
  public IEntityIOOutput OnSpawnGroupUnloadStarted {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x2537640F89E6672A));
  }
  public IEntityIOOutput OnSpawnGroupUnloadFinished {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x2537640F1268C477));
  }
  public ref CUtlSymbolLarge SpawnGroupName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x2537640FBEEECC58));
  }
  public ref CUtlSymbolLarge SpawnGroupFilterName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x2537640FE9A4A47E));
  }
  public ref CUtlSymbolLarge LandmarkName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x2537640F3207F70E));
  }
  public ref CUtlString FixedSpawnGroupName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x2537640FB094CD41));
  }
  public ref float TimeoutInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2537640F354D6687));
  }
  public ref bool AutoActivate {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2537640F8DAF22D7));
  }
  public ref bool UnloadingStarted {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2537640F11D7B43F));
  }
  public ref bool QueueActiveSpawnGroupChange {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2537640FC2B29DC8));
  }
  public ref bool QueueFinishLoading {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2537640F39EC1459));
  }


}
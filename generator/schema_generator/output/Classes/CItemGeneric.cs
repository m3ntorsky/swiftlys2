using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CItemGeneric : CItem, IItemGeneric {

  public CItemGeneric(nint handle) : base(handle) {
  }

  public ref bool HasTriggerRadius {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE5C051B6D8BAB96B));
  }
  public ref bool HasPickupRadius {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE5C051B6665CA089));
  }
  public ref float PickupRadiusSqr {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE5C051B6B3C8BD69));
  }
  public ref float TriggerRadiusSqr {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE5C051B64E7B40B7));
  }
  public IGameTime_t LastPickupCheck {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xE5C051B6CE974DB1));
  }
  public ref bool PlayerCounterListenerAdded {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE5C051B6198E288E));
  }
  public ref bool PlayerInTriggerRadius {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE5C051B66DC39F9F));
  }
  public CStrongHandle<IInfoForResourceTypeIParticleSystemDefinition> SpawnParticleEffect {
    get => new CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>(_Handle + Schema.GetOffset(0xE5C051B6576146D5));
  }
  public ref CUtlSymbolLarge AmbientSoundEffect {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xE5C051B65DD78861));
  }
  public ref bool AutoStartAmbientSound {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE5C051B678660D41));
  }
  public ref CUtlSymbolLarge SpawnScriptFunction {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xE5C051B6BC2C9805));
  }
  public CStrongHandle<IInfoForResourceTypeIParticleSystemDefinition> PickupParticleEffect {
    get => new CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>(_Handle + Schema.GetOffset(0xE5C051B6A61E7280));
  }
  public ref CUtlSymbolLarge PickupSoundEffect {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xE5C051B6ECB75E7B));
  }
  public ref CUtlSymbolLarge PickupScriptFunction {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xE5C051B64242F490));
  }
  public CStrongHandle<IInfoForResourceTypeIParticleSystemDefinition> TimeoutParticleEffect {
    get => new CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>(_Handle + Schema.GetOffset(0xE5C051B6FE95C38D));
  }
  public ref CUtlSymbolLarge TimeoutSoundEffect {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xE5C051B6F5AD0260));
  }
  public ref CUtlSymbolLarge TimeoutScriptFunction {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xE5C051B6E8BF2F2D));
  }
  public ref CUtlSymbolLarge PickupFilterName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xE5C051B613C0B032));
  }
  public CHandle<IBaseFilter> PickupFilter {
    get => new CHandle<CBaseFilter>(_Handle + Schema.GetOffset(0xE5C051B605240E41));
  }
  public IEntityIOOutput OnPickup {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xE5C051B628BC1F6C));
  }
  public IEntityIOOutput OnTimeout {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xE5C051B6C5301603));
  }
  public IEntityIOOutput OnTriggerStartTouch {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xE5C051B66E537987));
  }
  public IEntityIOOutput OnTriggerTouch {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xE5C051B63BCAE033));
  }
  public IEntityIOOutput OnTriggerEndTouch {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xE5C051B63DA3CB84));
  }
  public ref CUtlSymbolLarge AllowPickupScriptFunction {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xE5C051B6DC2DF75F));
  }
  public ref float PickupRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE5C051B64EED9A9D));
  }
  public ref float TriggerRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE5C051B6051F7F0F));
  }
  public ref CUtlSymbolLarge TriggerSoundEffect {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xE5C051B67E4EA459));
  }
  public ref bool GlowWhenInTrigger {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE5C051B6FCAD755D));
  }
  public ref Color GlowColor {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xE5C051B674A5EE03));
  }
  public ref bool Useable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE5C051B6E4DBE46C));
  }
  public CHandle<IItemGenericTriggerHelper> TriggerHelper {
    get => new CHandle<CItemGenericTriggerHelper>(_Handle + Schema.GetOffset(0xE5C051B62DCBD7A9));
  }


}
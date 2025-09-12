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
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> SpawnParticleEffect {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>>(Schema.GetOffset(0xE5C051B6576146D5));
  }
  public ISchemaUntypedField AmbientSoundEffect {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xE5C051B65DD78861));
  }
  public ref bool AutoStartAmbientSound {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE5C051B678660D41));
  }
  public ISchemaUntypedField SpawnScriptFunction {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xE5C051B6BC2C9805));
  }
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> PickupParticleEffect {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>>(Schema.GetOffset(0xE5C051B6A61E7280));
  }
  public ISchemaUntypedField PickupSoundEffect {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xE5C051B6ECB75E7B));
  }
  public ISchemaUntypedField PickupScriptFunction {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xE5C051B64242F490));
  }
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> TimeoutParticleEffect {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>>(Schema.GetOffset(0xE5C051B6FE95C38D));
  }
  public ISchemaUntypedField TimeoutSoundEffect {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xE5C051B6F5AD0260));
  }
  public ISchemaUntypedField TimeoutScriptFunction {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xE5C051B6E8BF2F2D));
  }
  public ISchemaUntypedField PickupFilterName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xE5C051B613C0B032));
  }
  public ref CHandle<CBaseFilter> PickupFilter {
    get => ref _Handle.AsRef<CHandle<CBaseFilter>>(Schema.GetOffset(0xE5C051B605240E41));
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
  public ISchemaUntypedField AllowPickupScriptFunction {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xE5C051B6DC2DF75F));
  }
  public ref float PickupRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE5C051B64EED9A9D));
  }
  public ref float TriggerRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE5C051B6051F7F0F));
  }
  public ISchemaUntypedField TriggerSoundEffect {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xE5C051B67E4EA459));
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
  public ref CHandle<CItemGenericTriggerHelper> TriggerHelper {
    get => ref _Handle.AsRef<CHandle<CItemGenericTriggerHelper>>(Schema.GetOffset(0xE5C051B62DCBD7A9));
  }


}
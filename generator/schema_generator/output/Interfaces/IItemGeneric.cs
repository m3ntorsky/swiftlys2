using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IItemGeneric : IItem {

  
  public ref bool HasTriggerRadius { get; }
  
  public ref bool HasPickupRadius { get; }
  
  public ref float PickupRadiusSqr { get; }
  
  public ref float TriggerRadiusSqr { get; }
  
  public IGameTime_t LastPickupCheck { get; }
  
  public ref bool PlayerCounterListenerAdded { get; }
  
  public ref bool PlayerInTriggerRadius { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> SpawnParticleEffect { get; }
  
  public ISchemaUntypedField AmbientSoundEffect { get; }
  
  public ref bool AutoStartAmbientSound { get; }
  
  public ISchemaUntypedField SpawnScriptFunction { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> PickupParticleEffect { get; }
  
  public ISchemaUntypedField PickupSoundEffect { get; }
  
  public ISchemaUntypedField PickupScriptFunction { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> TimeoutParticleEffect { get; }
  
  public ISchemaUntypedField TimeoutSoundEffect { get; }
  
  public ISchemaUntypedField TimeoutScriptFunction { get; }
  
  public ISchemaUntypedField PickupFilterName { get; }
  
  public ref CHandle<CBaseFilter> PickupFilter { get; }
  
  public IEntityIOOutput OnPickup { get; }
  
  public IEntityIOOutput OnTimeout { get; }
  
  public IEntityIOOutput OnTriggerStartTouch { get; }
  
  public IEntityIOOutput OnTriggerTouch { get; }
  
  public IEntityIOOutput OnTriggerEndTouch { get; }
  
  public ISchemaUntypedField AllowPickupScriptFunction { get; }
  
  public ref float PickupRadius { get; }
  
  public ref float TriggerRadius { get; }
  
  public ISchemaUntypedField TriggerSoundEffect { get; }
  
  public ref bool GlowWhenInTrigger { get; }
  
  public ref Color GlowColor { get; }
  
  public ref bool Useable { get; }
  
  public ref CHandle<CItemGenericTriggerHelper> TriggerHelper { get; }
}
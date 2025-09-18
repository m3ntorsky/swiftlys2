
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CUserMsg_ParticleManagerImpl : TypedProtobuf<CUserMsg_ParticleManager>, CUserMsg_ParticleManager
{
  public CUserMsg_ParticleManagerImpl(nint handle): base(handle)
  {
  }


  public PARTICLE_MESSAGE Type
  { get => (PARTICLE_MESSAGE)Accessor.GetInt32("type"); set => Accessor.SetInt32("type", (int)value); }


  public uint Index
  { get => Accessor.GetUInt32("index"); set => Accessor.SetUInt32("index", value); }


  public CUserMsg_ParticleManager_ReleaseParticleIndex ReleaseParticleIndex
  { get => new CUserMsg_ParticleManager_ReleaseParticleIndexImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "release_particle_index")); }


  public CUserMsg_ParticleManager_CreateParticle CreateParticle
  { get => new CUserMsg_ParticleManager_CreateParticleImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "create_particle")); }


  public CUserMsg_ParticleManager_DestroyParticle DestroyParticle
  { get => new CUserMsg_ParticleManager_DestroyParticleImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "destroy_particle")); }


  public CUserMsg_ParticleManager_DestroyParticleInvolving DestroyParticleInvolving
  { get => new CUserMsg_ParticleManager_DestroyParticleInvolvingImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "destroy_particle_involving")); }


  public CUserMsg_ParticleManager_UpdateParticle_OBSOLETE UpdateParticle
  { get => new CUserMsg_ParticleManager_UpdateParticle_OBSOLETEImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "update_particle")); }


  public CUserMsg_ParticleManager_UpdateParticleFwd_OBSOLETE UpdateParticleFwd
  { get => new CUserMsg_ParticleManager_UpdateParticleFwd_OBSOLETEImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "update_particle_fwd")); }


  public CUserMsg_ParticleManager_UpdateParticleOrient_OBSOLETE UpdateParticleOrient
  { get => new CUserMsg_ParticleManager_UpdateParticleOrient_OBSOLETEImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "update_particle_orient")); }


  public CUserMsg_ParticleManager_UpdateParticleFallback UpdateParticleFallback
  { get => new CUserMsg_ParticleManager_UpdateParticleFallbackImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "update_particle_fallback")); }


  public CUserMsg_ParticleManager_UpdateParticleOffset UpdateParticleOffset
  { get => new CUserMsg_ParticleManager_UpdateParticleOffsetImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "update_particle_offset")); }


  public CUserMsg_ParticleManager_UpdateParticleEnt UpdateParticleEnt
  { get => new CUserMsg_ParticleManager_UpdateParticleEntImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "update_particle_ent")); }


  public CUserMsg_ParticleManager_UpdateParticleShouldDraw UpdateParticleShouldDraw
  { get => new CUserMsg_ParticleManager_UpdateParticleShouldDrawImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "update_particle_should_draw")); }


  public CUserMsg_ParticleManager_UpdateParticleSetFrozen UpdateParticleSetFrozen
  { get => new CUserMsg_ParticleManager_UpdateParticleSetFrozenImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "update_particle_set_frozen")); }


  public CUserMsg_ParticleManager_ChangeControlPointAttachment ChangeControlPointAttachment
  { get => new CUserMsg_ParticleManager_ChangeControlPointAttachmentImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "change_control_point_attachment")); }


  public CUserMsg_ParticleManager_UpdateEntityPosition UpdateEntityPosition
  { get => new CUserMsg_ParticleManager_UpdateEntityPositionImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "update_entity_position")); }


  public CUserMsg_ParticleManager_SetParticleFoWProperties SetParticleFowProperties
  { get => new CUserMsg_ParticleManager_SetParticleFoWPropertiesImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_particle_fow_properties")); }


  public CUserMsg_ParticleManager_SetParticleText SetParticleText
  { get => new CUserMsg_ParticleManager_SetParticleTextImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_particle_text")); }


  public CUserMsg_ParticleManager_SetParticleShouldCheckFoW SetParticleShouldCheckFow
  { get => new CUserMsg_ParticleManager_SetParticleShouldCheckFoWImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_particle_should_check_fow")); }


  public CUserMsg_ParticleManager_SetControlPointModel SetControlPointModel
  { get => new CUserMsg_ParticleManager_SetControlPointModelImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_control_point_model")); }


  public CUserMsg_ParticleManager_SetControlPointSnapshot SetControlPointSnapshot
  { get => new CUserMsg_ParticleManager_SetControlPointSnapshotImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_control_point_snapshot")); }


  public CUserMsg_ParticleManager_SetTextureAttribute SetTextureAttribute
  { get => new CUserMsg_ParticleManager_SetTextureAttributeImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_texture_attribute")); }


  public CUserMsg_ParticleManager_SetSceneObjectGenericFlag SetSceneObjectGenericFlag
  { get => new CUserMsg_ParticleManager_SetSceneObjectGenericFlagImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_scene_object_generic_flag")); }


  public CUserMsg_ParticleManager_SetSceneObjectTintAndDesat SetSceneObjectTintAndDesat
  { get => new CUserMsg_ParticleManager_SetSceneObjectTintAndDesatImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_scene_object_tint_and_desat")); }


  public CUserMsg_ParticleManager_DestroyParticleNamed DestroyParticleNamed
  { get => new CUserMsg_ParticleManager_DestroyParticleNamedImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "destroy_particle_named")); }


  public CUserMsg_ParticleManager_ParticleSkipToTime ParticleSkipToTime
  { get => new CUserMsg_ParticleManager_ParticleSkipToTimeImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "particle_skip_to_time")); }


  public CUserMsg_ParticleManager_ParticleCanFreeze ParticleCanFreeze
  { get => new CUserMsg_ParticleManager_ParticleCanFreezeImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "particle_can_freeze")); }


  public CUserMsg_ParticleManager_SetParticleNamedValueContext SetNamedValueContext
  { get => new CUserMsg_ParticleManager_SetParticleNamedValueContextImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_named_value_context")); }


  public CUserMsg_ParticleManager_UpdateParticleTransform UpdateParticleTransform
  { get => new CUserMsg_ParticleManager_UpdateParticleTransformImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "update_particle_transform")); }


  public CUserMsg_ParticleManager_ParticleFreezeTransitionOverride ParticleFreezeTransitionOverride
  { get => new CUserMsg_ParticleManager_ParticleFreezeTransitionOverrideImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "particle_freeze_transition_override")); }


  public CUserMsg_ParticleManager_FreezeParticleInvolving FreezeParticleInvolving
  { get => new CUserMsg_ParticleManager_FreezeParticleInvolvingImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "freeze_particle_involving")); }


  public CUserMsg_ParticleManager_AddModellistOverrideElement AddModellistOverrideElement
  { get => new CUserMsg_ParticleManager_AddModellistOverrideElementImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "add_modellist_override_element")); }


  public CUserMsg_ParticleManager_ClearModellistOverride ClearModellistOverride
  { get => new CUserMsg_ParticleManager_ClearModellistOverrideImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "clear_modellist_override")); }


  public CUserMsg_ParticleManager_CreatePhysicsSim CreatePhysicsSim
  { get => new CUserMsg_ParticleManager_CreatePhysicsSimImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "create_physics_sim")); }


  public CUserMsg_ParticleManager_DestroyPhysicsSim DestroyPhysicsSim
  { get => new CUserMsg_ParticleManager_DestroyPhysicsSimImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "destroy_physics_sim")); }


  public CUserMsg_ParticleManager_SetVData SetVdata
  { get => new CUserMsg_ParticleManager_SetVDataImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_vdata")); }


  public CUserMsg_ParticleManager_SetMaterialOverride SetMaterialOverride
  { get => new CUserMsg_ParticleManager_SetMaterialOverrideImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_material_override")); }


  public CUserMsg_ParticleManager_AddFan AddFan
  { get => new CUserMsg_ParticleManager_AddFanImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "add_fan")); }


  public CUserMsg_ParticleManager_UpdateFan UpdateFan
  { get => new CUserMsg_ParticleManager_UpdateFanImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "update_fan")); }


  public CUserMsg_ParticleManager_SetParticleClusterGrowth SetParticleClusterGrowth
  { get => new CUserMsg_ParticleManager_SetParticleClusterGrowthImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "set_particle_cluster_growth")); }

}

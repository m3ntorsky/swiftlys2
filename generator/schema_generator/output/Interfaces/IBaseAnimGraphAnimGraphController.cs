using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseAnimGraphAnimGraphController : IAnimGraphControllerBase {

  public ISchemaUntypedField DestructiblePartDestroyedHitGroup { get; }
  
  public ISchemaUntypedField DestructiblePartDestroyedPartIndex { get; }
  
  public ISchemaUntypedField HITGROUP_INVALID_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_GENERIC_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_HEAD_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_CHEST_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_STOMACH_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_LEFTARM_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_RIGHTARM_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_LEFTLEG_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_RIGHTLEG_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_NECK_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_UNUSED_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_GEAR_Destroyed { get; }
  
  public ISchemaUntypedField HITGROUP_SPECIAL_Destroyed { get; }
  
}
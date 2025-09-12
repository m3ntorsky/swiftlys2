using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerLerpObject : IBaseTrigger {

  
  public ISchemaUntypedField LerpTarget { get; }
  
  public ref CHandle<CBaseEntity> LerpTarget { get; }
  
  public ISchemaUntypedField LerpTargetAttachment { get; }
  
  public IAttachmentHandle_t LerpTargetAttachment { get; }
  
  public ref float LerpDuration { get; }
  
  public ref bool LerpRestoreMoveType { get; }
  
  public ref bool SingleLerpObject { get; }
  
// CUtlVector< lerpdata_t >
  public ref CUtlVector LerpingObjects { get; }
  
  public ISchemaUntypedField LerpEffect { get; }
  
  public ISchemaUntypedField LerpSound { get; }
  
  public ref bool AttachTouchingObject { get; }
  
  public ref CHandle<CBaseEntity> EntityToWaitForDisconnect { get; }
  
  public IEntityIOOutput OnLerpStarted { get; }
  
  public IEntityIOOutput OnLerpFinished { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerLerpObject : IBaseTrigger {

  public ref CUtlSymbolLarge LerpTarget { get; }
  
  public ref CHandle<CBaseEntity> LerpTarget { get; }
  
  public ref CUtlSymbolLarge LerpTargetAttachment { get; }
  
  public IAttachmentHandle_t LerpTargetAttachment { get; }
  
  public ref float LerpDuration { get; }
  
  public ref bool LerpRestoreMoveType { get; }
  
  public ref bool SingleLerpObject { get; }
  
  public ref CUtlVector LerpingObjects { get; }
  
  public ref CUtlSymbolLarge LerpEffect { get; }
  
  public ref CUtlSymbolLarge LerpSound { get; }
  
  public ref bool AttachTouchingObject { get; }
  
  public ref CHandle<CBaseEntity> EntityToWaitForDisconnect { get; }
  
  public IEntityIOOutput OnLerpStarted { get; }
  
  public IEntityIOOutput OnLerpFinished { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointCommentaryNode : IBaseAnimGraph {

  
  public ISchemaUntypedField PreCommands { get; }
  
  public ISchemaUntypedField PostCommands { get; }
  
  public ISchemaUntypedField CommentaryFile { get; }
  
  public ISchemaUntypedField ViewTarget { get; }
  
  public ref CHandle<CBaseEntity> ViewTarget { get; }
  
  public ref CHandle<CBaseEntity> ViewTargetAngles { get; }
  
  public ISchemaUntypedField ViewPosition { get; }
  
  public ref CHandle<CBaseEntity> ViewPosition { get; }
  
  public ref CHandle<CBaseEntity> ViewPositionMover { get; }
  
  public ref bool PreventMovement { get; }
  
  public ref bool UnderCrosshair { get; }
  
  public ref bool Unstoppable { get; }
  
  public IGameTime_t FinishedTime { get; }
  
  public ref Vector FinishOrigin { get; }
  
  public ref QAngle OriginalAngles { get; }
  
  public ref QAngle FinishAngles { get; }
  
  public ref bool PreventChangesWhileMoving { get; }
  
  public ref bool Disabled { get; }
  
  public ref Vector TeleportOrigin { get; }
  
  public IGameTime_t AbortedPlaybackAt { get; }
  
  public IEntityIOOutput OnCommentaryStarted { get; }
  
  public IEntityIOOutput OnCommentaryStopped { get; }
  
  public ref bool Active { get; }
  
  public IGameTime_t StartTime { get; }
  
  public ref float StartTimeInCommentary { get; }
  
  public ISchemaUntypedField Title { get; }
  
  public ISchemaUntypedField Speakers { get; }
  
  public ref int NodeNumber { get; }
  
  public ref int NodeNumberMax { get; }
  
  public ref bool ListenedTo { get; }
}
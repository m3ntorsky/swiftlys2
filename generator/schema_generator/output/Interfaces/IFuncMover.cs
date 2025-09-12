using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncMover : IBaseModelEntity {

  
  public ISchemaUntypedField PathName { get; }
  
  public ref CHandle<CPathMover> PathMover { get; }
  
  public ISchemaUntypedField PathNodeStart { get; }
  
  public ISchemaUntypedField PathNodeEnd { get; }
  
  public ref CFuncMover::Move_t MoveType { get; }
  
  public ref bool IsReversing { get; }
  
  public ref Vector Target { get; }
  
  public ref float StartSpeed { get; }
  
  public ref float PathLocation { get; }
  
  public ref float T { get; }
  
  public ref int CurrentNodeIndex { get; }
  
  public ref int PreviousNodeIndex { get; }
  
  public ref SolidType_t SolidType { get; }
  
  public ref bool IsMoving { get; }
  
  public ref float TimeToReachMaxSpeed { get; }
  
  public ref float DistanceToReachMaxSpeed { get; }
  
  public ref float TimeToReachZeroSpeed { get; }
  
  public ref float DistanceToReachZeroSpeed { get; }
  
  public IGameTime_t TimeMovementStart { get; }
  
  public IGameTime_t TimeMovementStop { get; }
  
  public ref CHandle<CMoverPathNode> StopAtNode { get; }
  
  public ref float PathLocationToBeginStop { get; }
  
  public ISchemaUntypedField StartForwardSound { get; }
  
  public ISchemaUntypedField LoopForwardSound { get; }
  
  public ISchemaUntypedField StopForwardSound { get; }
  
  public ISchemaUntypedField StartReverseSound { get; }
  
  public ISchemaUntypedField LoopReverseSound { get; }
  
  public ISchemaUntypedField StopReverseSound { get; }
  
  public ISchemaUntypedField ArriveAtDestinationSound { get; }
  
  public IEntityIOOutput OnMovementEnd { get; }
  
  public ref bool StartAtClosestPoint { get; }
  
  public ref bool StartAtEnd { get; }
  
  public ref CFuncMover::OrientationUpdate_t OrientationUpdate { get; }
  
  public IGameTime_t TimeStartOrientationChange { get; }
  
  public ref float TimeToBlendToNewOrientation { get; }
  
  public ref float DurationBlendToNewOrientationRan { get; }
  
  public ref int OriginalOrientationIndex { get; }
  
  public ref bool CreateMovableNavMesh { get; }
  
  public ref bool AllowMovableNavMeshDockingOnEntireEntity { get; }
  
  public IEntityIOOutput OnNodePassed { get; }
  
  public ISchemaUntypedField OrientationMatchEntityName { get; }
  
  public ref CHandle<CBaseEntity> OrientationMatchEntity { get; }
  
  public ref float TimeToTraverseToNextNode { get; }
  
  public ref Vector LerpToNewPosStartInPathEntitySpace { get; }
  
  public ref Vector LerpToNewPosEndInPathEntitySpace { get; }
  
  public ref float LerpToPositionT { get; }
  
  public ref float LerpToPositionDeltaT { get; }
  
  public IEntityIOOutput OnLerpToPositionComplete { get; }
  
  public ref bool IsPaused { get; }
  
  public ref CFuncMover::TransitionToPathNodeAction_t TransitionedToPathNodeAction { get; }
  
  public ref int DelayedTeleportToNode { get; }
  
  public ref bool IsVerboseLogging { get; }
  
  public ref CHandle<CBaseEntity> FollowEntity { get; }
  
  public ref float FollowDistance { get; }
  
  public ref float FollowMinimumSpeed { get; }
  
  public ref float CurFollowEntityT { get; }
  
  public ref float CurFollowSpeed { get; }
  
  public ISchemaUntypedField StrOrientationFaceEntityName { get; }
  
  public ref CHandle<CBaseEntity> OrientationFaceEntity { get; }
  
  public IEntityIOOutput OnStart { get; }
  
  public IEntityIOOutput OnStartForward { get; }
  
  public IEntityIOOutput OnStartReverse { get; }
  
  public IEntityIOOutput OnStop { get; }
  
  public IEntityIOOutput OnStopped { get; }
  
  public ref bool NextNodeReturnsCurrent { get; }
  
  public ref bool StartedMoving { get; }
  
  public ref CFuncMover::FollowEntityDirection_t FollowEntityDirection { get; }
}
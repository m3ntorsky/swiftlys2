using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncMover : CBaseModelEntity, IFuncMover {

  public CFuncMover(nint handle) : base(handle) {
  }

  public ISchemaUntypedField PathName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B6981A419FD));
  }
  public ref CHandle<CPathMover> PathMover {
    get => ref _Handle.AsRef<CHandle<CPathMover>>(Schema.GetOffset(0x320E8B69AFA877CD));
  }
  public ISchemaUntypedField PathNodeStart {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B691B0A1252));
  }
  public ISchemaUntypedField PathNodeEnd {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B69F1D1AED7));
  }
  public ref CFuncMover::Move_t MoveType {
    get => ref _Handle.AsRef<CFuncMover::Move_t>(Schema.GetOffset(0x320E8B69E635C185));
  }
  public ref bool IsReversing {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x320E8B69899E5BEE));
  }
  public ref Vector Target {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x320E8B69C61225FC));
  }
  public ref float StartSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B695EAB0EE0));
  }
  public ref float PathLocation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B694232CFBF));
  }
  public ref float T {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B6993122981));
  }
  public ref int CurrentNodeIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x320E8B6948C15E6E));
  }
  public ref int PreviousNodeIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x320E8B690BA7740C));
  }
  public ref SolidType_t SolidType {
    get => ref _Handle.AsRef<SolidType_t>(Schema.GetOffset(0x320E8B695B4C380F));
  }
  public ref bool IsMoving {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x320E8B69874D1717));
  }
  public ref float TimeToReachMaxSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B699452902F));
  }
  public ref float DistanceToReachMaxSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B6907733475));
  }
  public ref float TimeToReachZeroSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B69816228FB));
  }
  public ref float DistanceToReachZeroSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B69354237E9));
  }
  public IGameTime_t TimeMovementStart {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x320E8B69CD2B8B85));
  }
  public IGameTime_t TimeMovementStop {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x320E8B696E9B82D7));
  }
  public ref CHandle<CMoverPathNode> StopAtNode {
    get => ref _Handle.AsRef<CHandle<CMoverPathNode>>(Schema.GetOffset(0x320E8B6907744C56));
  }
  public ref float PathLocationToBeginStop {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B69976C5777));
  }
  public ISchemaUntypedField StartForwardSound {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B69CBDFD56B));
  }
  public ISchemaUntypedField LoopForwardSound {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B69C875F2F7));
  }
  public ISchemaUntypedField StopForwardSound {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B69B72A6EC9));
  }
  public ISchemaUntypedField StartReverseSound {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B6927D9C282));
  }
  public ISchemaUntypedField LoopReverseSound {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B69FC2C15CE));
  }
  public ISchemaUntypedField StopReverseSound {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B69B0EFF4BC));
  }
  public ISchemaUntypedField ArriveAtDestinationSound {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B696350F6A0));
  }
  public IEntityIOOutput OnMovementEnd {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x320E8B699BD1966A));
  }
  public ref bool StartAtClosestPoint {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x320E8B69FBBC7ACD));
  }
  public ref bool StartAtEnd {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x320E8B694B214AF7));
  }
  public ref CFuncMover::OrientationUpdate_t OrientationUpdate {
    get => ref _Handle.AsRef<CFuncMover::OrientationUpdate_t>(Schema.GetOffset(0x320E8B69D0D215E3));
  }
  public IGameTime_t TimeStartOrientationChange {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x320E8B698090B2A8));
  }
  public ref float TimeToBlendToNewOrientation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B69F64E85BB));
  }
  public ref float DurationBlendToNewOrientationRan {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B693B19BF08));
  }
  public ref int OriginalOrientationIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x320E8B69A132531C));
  }
  public ref bool CreateMovableNavMesh {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x320E8B6985442AAF));
  }
  public ref bool AllowMovableNavMeshDockingOnEntireEntity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x320E8B690CC0563A));
  }
  public IEntityIOOutput OnNodePassed {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x320E8B69709328FC));
  }
  public ISchemaUntypedField OrientationMatchEntityName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B69384CF18A));
  }
  public ref CHandle<CBaseEntity> OrientationMatchEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x320E8B6924A0D317));
  }
  public ref float TimeToTraverseToNextNode {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B6942129DF9));
  }
  public ref Vector LerpToNewPosStartInPathEntitySpace {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x320E8B6958D80CD2));
  }
  public ref Vector LerpToNewPosEndInPathEntitySpace {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x320E8B698269BEB5));
  }
  public ref float LerpToPositionT {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B69C191D824));
  }
  public ref float LerpToPositionDeltaT {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B69A0AFA3BE));
  }
  public IEntityIOOutput OnLerpToPositionComplete {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x320E8B693D72E078));
  }
  public ref bool IsPaused {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x320E8B690BA146BB));
  }
  public ref CFuncMover::TransitionToPathNodeAction_t TransitionedToPathNodeAction {
    get => ref _Handle.AsRef<CFuncMover::TransitionToPathNodeAction_t>(Schema.GetOffset(0x320E8B696FEE6BBE));
  }
  public ref int DelayedTeleportToNode {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x320E8B69A71F8CA3));
  }
  public ref bool IsVerboseLogging {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x320E8B6963292696));
  }
  public ref CHandle<CBaseEntity> FollowEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x320E8B6969846129));
  }
  public ref float FollowDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B69CF6A55D9));
  }
  public ref float FollowMinimumSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B69929585C9));
  }
  public ref float CurFollowEntityT {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B6977610EE3));
  }
  public ref float CurFollowSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x320E8B6958BEEE69));
  }
  public ISchemaUntypedField StrOrientationFaceEntityName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x320E8B694B008CC7));
  }
  public ref CHandle<CBaseEntity> OrientationFaceEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x320E8B696BA187E1));
  }
  public IEntityIOOutput OnStart {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x320E8B69C3FE848C));
  }
  public IEntityIOOutput OnStartForward {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x320E8B69FC63B371));
  }
  public IEntityIOOutput OnStartReverse {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x320E8B693AC2BDEA));
  }
  public IEntityIOOutput OnStop {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x320E8B6915A596E8));
  }
  public IEntityIOOutput OnStopped {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x320E8B69161C44C9));
  }
  public ref bool NextNodeReturnsCurrent {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x320E8B69097A17E4));
  }
  public ref bool StartedMoving {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x320E8B6939B1504C));
  }
  public ref CFuncMover::FollowEntityDirection_t FollowEntityDirection {
    get => ref _Handle.AsRef<CFuncMover::FollowEntityDirection_t>(Schema.GetOffset(0x320E8B69E14C9BB7));
  }


}
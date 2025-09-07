using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHostage : CHostageExpresserShim, IHostage {

  public CHostage(nint handle) : base(handle) {
  }

  public CHostage(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OnHostageBeginGrab {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1A122BDF0DA44EAC));
  }
  public IEntityIOOutput OnFirstPickedUp {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1A122BDFCBF60E53));
  }
  public IEntityIOOutput OnDroppedNotRescued {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1A122BDFE6BC925E));
  }
  public IEntityIOOutput OnRescued {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1A122BDF421F0657));
  }
  public IEntitySpottedState_t EntitySpottedState {
    get => new EntitySpottedState_t(_Handle + Schema.GetOffset(0x1A122BDF032B547C));
  }
  public ref int SpotRules {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1A122BDF776CCE44));
  }
  public ref uint UiHostageSpawnExclusionGroupMask {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x1A122BDF1F6BC7DC));
  }
  public ref uint HostageSpawnRandomFactor {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x1A122BDFD6DEF099));
  }
  public ref bool Remove {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A122BDFDE0A6D5D));
  }
  public ref Vector Vel {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1A122BDF62514398));
  }
  public ref bool IsRescued {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A122BDF18E05CC8));
  }
  public ref bool JumpedThisFrame {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A122BDF6BF897BD));
  }
  public ref int HostageState {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1A122BDF5B4A8B2F));
  }
  public ref CHandle< CBaseEntity > Leader {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x1A122BDF658B4E84));
  }
  public ref CHandle< CCSPlayerPawnBase > LastLeader {
    get => ref _Handle.AsRef<CHandle< CCSPlayerPawnBase >>(Schema.GetOffset(0x1A122BDF1598AC08));
  }
  public ICountdownTimer ReuseTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1A122BDF6D7BFBA8));
  }
  public ref bool HasBeenUsed {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A122BDF4B85A934));
  }
  public ref Vector Accel {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1A122BDF21A5D4B3));
  }
  public ref bool IsRunning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A122BDFE59BA57C));
  }
  public ref bool IsCrouching {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A122BDF7C7E997D));
  }
  public ICountdownTimer JumpTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1A122BDF6CBF3C9A));
  }
  public ref bool IsWaitingForLeader {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A122BDF1E830BB2));
  }
  public ICountdownTimer RepathTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1A122BDF4AEA977C));
  }
  public ICountdownTimer InhibitDoorTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1A122BDF4CDEAEF5));
  }
  public ICountdownTimer InhibitObstacleAvoidanceTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1A122BDF6310A196));
  }
  public ICountdownTimer WiggleTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x1A122BDFEDBA9421));
  }
  public ref bool IsAdjusted {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A122BDFA875F12F));
  }
  public ref bool HandsHaveBeenCut {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A122BDF36E822D3));
  }
  public ref CHandle< CCSPlayerPawn > HostageGrabber {
    get => ref _Handle.AsRef<CHandle< CCSPlayerPawn >>(Schema.GetOffset(0x1A122BDF052DBC9F));
  }
  public IGameTime_t LastGrabTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1A122BDFCF347506));
  }
  public ref Vector PositionWhenStartedDroppingToGround {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1A122BDF59A358F0));
  }
  public ref Vector GrabbedPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1A122BDFBB7B9A0C));
  }
  public IGameTime_t RescueStartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1A122BDF6085D94B));
  }
  public IGameTime_t GrabSuccessTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1A122BDF2EA3F531));
  }
  public IGameTime_t DropStartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1A122BDF61FA47CF));
  }
  public ref int ApproachRewardPayouts {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1A122BDF985F9A31));
  }
  public ref int PickupEventCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1A122BDF3D4AD912));
  }
  public ref Vector SpawnGroundPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1A122BDFF05F3703));
  }
  public ref Vector HostageResetPosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1A122BDF81ABDB0E));
  }

  public void EntitySpottedStateUpdated() {
    Schema.Update(_Handle, 0x1A122BDF032B547C);
  }
  public void VelUpdated() {
    Schema.Update(_Handle, 0x1A122BDF62514398);
  }
  public void IsRescuedUpdated() {
    Schema.Update(_Handle, 0x1A122BDF18E05CC8);
  }
  public void JumpedThisFrameUpdated() {
    Schema.Update(_Handle, 0x1A122BDF6BF897BD);
  }
  public void HostageStateUpdated() {
    Schema.Update(_Handle, 0x1A122BDF5B4A8B2F);
  }
  public void LeaderUpdated() {
    Schema.Update(_Handle, 0x1A122BDF658B4E84);
  }
  public void ReuseTimerUpdated() {
    Schema.Update(_Handle, 0x1A122BDF6D7BFBA8);
  }
  public void HandsHaveBeenCutUpdated() {
    Schema.Update(_Handle, 0x1A122BDF36E822D3);
  }
  public void HostageGrabberUpdated() {
    Schema.Update(_Handle, 0x1A122BDF052DBC9F);
  }
  public void RescueStartTimeUpdated() {
    Schema.Update(_Handle, 0x1A122BDF6085D94B);
  }
  public void GrabSuccessTimeUpdated() {
    Schema.Update(_Handle, 0x1A122BDF2EA3F531);
  }
  public void DropStartTimeUpdated() {
    Schema.Update(_Handle, 0x1A122BDF61FA47CF);
  }
}
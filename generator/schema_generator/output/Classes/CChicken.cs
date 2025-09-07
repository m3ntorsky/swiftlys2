using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CChicken : CDynamicProp, IChicken {

  public CChicken(nint handle) : base(handle) {
  }

  public CChicken(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAttributeContainer AttributeManager {
    get => new CAttributeContainer(_Handle + Schema.GetOffset(0x66D7920D537B0586));
  }
  public ICountdownTimer UpdateTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920DE92599E5));
  }
  public ref Vector StuckAnchor {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x66D7920D7FBA1852));
  }
  public ICountdownTimer StuckTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920D22E8E3F0));
  }
  public ICountdownTimer CollisionStuckTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920DDA840C2A));
  }
  public ref bool IsOnGround {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x66D7920D66E85E9B));
  }
  public ref Vector FallVelocity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x66D7920DE845FA27));
  }
  public ref ChickenActivity DesiredActivity {
    get => ref _Handle.AsRef<ChickenActivity>(Schema.GetOffset(0x66D7920D0BDF74DC));
  }
  public ref ChickenActivity CurrentActivity {
    get => ref _Handle.AsRef<ChickenActivity>(Schema.GetOffset(0x66D7920DBF339767));
  }
  public ICountdownTimer ActivityTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920D80BFBDAD));
  }
  public ref float TurnRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x66D7920D76FF88A8));
  }
  public ref CHandle< CBaseEntity > FleeFrom {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x66D7920D24941539));
  }
  public ICountdownTimer MoveRateThrottleTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920D7F3A963B));
  }
  public ICountdownTimer StartleTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920D5F30C195));
  }
  public ICountdownTimer VocalizeTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920D8A04CBE9));
  }
  public IGameTime_t WhenZombified {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x66D7920DEC63D622));
  }
  public ref bool JumpedThisFrame {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x66D7920D6BF897BD));
  }
  public ref CHandle< CCSPlayerPawn > Leader {
    get => ref _Handle.AsRef<CHandle< CCSPlayerPawn >>(Schema.GetOffset(0x66D7920D658B4E84));
  }
  public ICountdownTimer ReuseTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920D6D7BFBA8));
  }
  public ref bool HasBeenUsed {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x66D7920D4B85A934));
  }
  public ICountdownTimer JumpTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920D6CBF3C9A));
  }
  public ref float LastJumpTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x66D7920DAB061352));
  }
  public ref bool InJump {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x66D7920DD74EE446));
  }
  public ICountdownTimer RepathTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920D4AEA977C));
  }
  public ref Vector PathGoal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x66D7920DEF360269));
  }
  public IGameTime_t ActiveFollowStartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x66D7920D204FDDA9));
  }
  public ICountdownTimer FollowMinuteTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920DCDBFCCA9));
  }
  public ICountdownTimer BlockDirectionTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x66D7920D579BB6BC));
  }

  public void AttributeManagerUpdated() {
    Schema.Update(_Handle, 0x66D7920D537B0586);
  }
  public void JumpedThisFrameUpdated() {
    Schema.Update(_Handle, 0x66D7920D6BF897BD);
  }
  public void LeaderUpdated() {
    Schema.Update(_Handle, 0x66D7920D658B4E84);
  }
}
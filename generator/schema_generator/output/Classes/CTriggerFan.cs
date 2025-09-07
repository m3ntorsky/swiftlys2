using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerFan : CBaseTrigger, ITriggerFan {

  public CTriggerFan(nint handle) : base(handle) {
  }

  public CTriggerFan(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector FanOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6A8B5C2B53C49C18));
  }
  public ref Vector FanOriginOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6A8B5C2BAFB9770B));
  }
  public ref Vector FanEnd {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6A8B5C2BA34E3AAB));
  }
  public ref Vector NoiseDirectionTarget {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6A8B5C2B59781ABB));
  }
  public ref Vector Direction {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6A8B5C2BDAE41DEE));
  }
  public ref bool PushTowardsInfoTarget {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A8B5C2BB6D3B4CE));
  }
  public ref bool PushAwayFromInfoTarget {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A8B5C2BF3F3D5EE));
  }
  public ref Quaternion NoiseDelta {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x6A8B5C2BDC0D2AE8));
  }
  public ref CHandle< CInfoFan > InfoFan {
    get => ref _Handle.AsRef<CHandle< CInfoFan >>(Schema.GetOffset(0x6A8B5C2B423064AC));
  }
  public ref float Force {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A8B5C2BCA90E47A));
  }
  public ref bool Falloff {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A8B5C2B76E955A5));
  }
  public ICountdownTimer RampTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x6A8B5C2B21725ED6));
  }
  public ref CUtlSymbolLarge InfoFan {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x6A8B5C2B8E6431BA));
  }
  public ref float RopeForceScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A8B5C2B08EB54C8));
  }
  public ref float ParticleForceScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A8B5C2B8DB0C4D2));
  }
  public ref float PlayerForce {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A8B5C2B3081B6B5));
  }
  public ref bool PlayerWindblock {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A8B5C2B59B4AC7B));
  }
  public ref float NPCForce {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A8B5C2B9BD16135));
  }
  public ref float RampTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A8B5C2B7F655EF6));
  }
  public ref float NoiseDegrees {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A8B5C2BB9B3398E));
  }
  public ref float NoiseSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A8B5C2B5C5BB620));
  }
  public ref bool PushPlayer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A8B5C2B9DD4D118));
  }
  public ref bool RampDown {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A8B5C2B16C1F4F9));
  }
  public ref int ManagerFanIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6A8B5C2B2401CC88));
  }

  public void FanOriginUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2B53C49C18);
  }
  public void FanOriginOffsetUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2BAFB9770B);
  }
  public void FanEndUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2BA34E3AAB);
  }
  public void NoiseDirectionTargetUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2B59781ABB);
  }
  public void DirectionUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2BDAE41DEE);
  }
  public void PushTowardsInfoTargetUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2BB6D3B4CE);
  }
  public void PushAwayFromInfoTargetUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2BF3F3D5EE);
  }
  public void NoiseDeltaUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2BDC0D2AE8);
  }
  public void InfoFanUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2B423064AC);
  }
  public void ForceUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2BCA90E47A);
  }
  public void FalloffUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2B76E955A5);
  }
  public void RampTimerUpdated() {
    Schema.Update(_Handle, 0x6A8B5C2B21725ED6);
  }
}
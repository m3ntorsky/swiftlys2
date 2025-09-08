using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncRotator : CBaseModelEntity, IFuncRotator {

  public CFuncRotator(nint handle) : base(handle) {
  }

  public CHandle<IBaseEntity> RotatorTarget {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x73DA1BB9F324C519));
  }
  public ref bool IsRotating {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x73DA1BB94C9E159D));
  }
  public ref bool IsReversing {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x73DA1BB9899E5BEE));
  }
  public ref float TimeToReachMaxSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x73DA1BB99452902F));
  }
  public ref float TimeToReachZeroSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x73DA1BB9816228FB));
  }
  public ref float DistanceAlongArcTraveled {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x73DA1BB9AF2FCEDE));
  }
  public ref float TimeToWaitOscillate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x73DA1BB96E3B4BF4));
  }
  public IGameTime_t TimeRotationStart {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x73DA1BB952C0B2E8));
  }
  public ref Quaternion LSPrevChange {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x73DA1BB9BC15BD54));
  }
  public ref Quaternion WSPrev {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x73DA1BB9C3EEEFFB));
  }
  public ref Quaternion WSInit {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x73DA1BB99E7E023C));
  }
  public ref Quaternion LSInit {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x73DA1BB966C62507));
  }
  public ref Quaternion LSOrientation {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x73DA1BB9BD794B25));
  }
  public IEntityIOOutput OnRotationStarted {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x73DA1BB9A2961697));
  }
  public IEntityIOOutput OnRotationCompleted {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x73DA1BB90478C90B));
  }
  public IEntityIOOutput OnOscillate {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x73DA1BB931B79B92));
  }
  public IEntityIOOutput OnOscillateStartArrive {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x73DA1BB996E9B88D));
  }
  public IEntityIOOutput OnOscillateStartDepart {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x73DA1BB908C9CF2C));
  }
  public IEntityIOOutput OnOscillateEndArrive {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x73DA1BB98F4F6014));
  }
  public IEntityIOOutput OnOscillateEndDepart {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x73DA1BB943D41D49));
  }
  public ref bool OscillateDepart {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x73DA1BB9CAB88EEB));
  }
  public ref int OscillateCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x73DA1BB9C2609150));
  }
  public ref CFuncRotator::Rotate_t RotateType {
    get => ref _Handle.AsRef<CFuncRotator::Rotate_t>(Schema.GetOffset(0x73DA1BB94BD69967));
  }
  public ref CFuncRotator::Rotate_t PrevRotateType {
    get => ref _Handle.AsRef<CFuncRotator::Rotate_t>(Schema.GetOffset(0x73DA1BB9DB4BE282));
  }
  public ref bool HasTargetOverride {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x73DA1BB9E91C45E6));
  }
  public ref Quaternion OrientationOverride {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x73DA1BB9EE27F696));
  }
  public ref RotatorTargetSpace_t SpaceOverride {
    get => ref _Handle.AsRef<RotatorTargetSpace_t>(Schema.GetOffset(0x73DA1BB9BAF52F16));
  }
  public ref QAngle AngularVelocity {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x73DA1BB9CB9A90B9));
  }
  public ref Vector LookAtForcedUp {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x73DA1BB948B272FF));
  }
  public ref CUtlSymbolLarge StrRotatorTarget {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x73DA1BB95D9EF510));
  }
  public ref bool RecordHistory {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x73DA1BB9A1A2B6DC));
  }
  public ref CUtlVector RotatorHistory {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x73DA1BB91907536A));
  }
  public ref bool ReturningToPreviousOrientation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x73DA1BB9540035F9));
  }
  public ref CUtlVector RotatorQueue {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x73DA1BB941C250ED));
  }
  public ref CUtlVector RotatorQueueHistory {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x73DA1BB9671778B7));
  }


}
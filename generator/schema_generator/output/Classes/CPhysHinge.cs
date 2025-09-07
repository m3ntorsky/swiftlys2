using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysHinge : CPhysConstraint, IPhysHinge {

  public CPhysHinge(nint handle) : base(handle) {
  }

  public CPhysHinge(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IConstraintSoundInfo SoundInfo {
    get => new ConstraintSoundInfo(_Handle + Schema.GetOffset(0xFCB149B185F704E8));
  }
  public IEntityIOOutput NotifyMinLimitReached {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xFCB149B1CD28EA23));
  }
  public IEntityIOOutput NotifyMaxLimitReached {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xFCB149B15B33E6AD));
  }
  public ref bool AtMinLimit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFCB149B119CAC3B7));
  }
  public ref bool AtMaxLimit {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFCB149B153E2D225));
  }
  public Iconstraint_hingeparams_t Hinge {
    get => new constraint_hingeparams_t(_Handle + Schema.GetOffset(0xFCB149B13923C0AC));
  }
  public ref float HingeFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFCB149B11390591E));
  }
  public ref float SystemLoadScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFCB149B19C24DB62));
  }
  public ref bool IsAxisLocal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFCB149B15A72A0AF));
  }
  public ref float MinRotation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFCB149B124801DAB));
  }
  public ref float MaxRotation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFCB149B1770EB7E9));
  }
  public ref float InitialRotation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFCB149B1C9493687));
  }
  public ref float MotorFrequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFCB149B156F7120A));
  }
  public ref float MotorDampingRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFCB149B1D8669699));
  }
  public ref float AngleSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFCB149B18CA05599));
  }
  public ref float AngleSpeedThreshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFCB149B141F77A9C));
  }
  public IEntityIOOutput OnStartMoving {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xFCB149B1F38945EA));
  }
  public IEntityIOOutput OnStopMoving {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xFCB149B1D3A538AE));
  }


}
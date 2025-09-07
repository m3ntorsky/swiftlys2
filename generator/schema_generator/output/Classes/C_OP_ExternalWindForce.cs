using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ExternalWindForce : CParticleFunctionForce, IC_OP_ExternalWindForce {

  public C_OP_ExternalWindForce(nint handle) : base(handle) {
  }

  public C_OP_ExternalWindForce(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleVecInput SamplePosition {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xFE6646FBC3F6C534));
  }
  public IPerParticleVecInput Scale {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xFE6646FB5F596B51));
  }
  public ref bool SampleWind {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFE6646FB3C2A72D1));
  }
  public ref bool SampleWater {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFE6646FB97B80806));
  }
  public ref bool DampenNearWaterPlane {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFE6646FB974DA031));
  }
  public ref bool SampleGravity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFE6646FB805373EF));
  }
  public IPerParticleVecInput GravityForce {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xFE6646FB2E2EF2C4));
  }
  public ref bool UseBasicMovementGravity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFE6646FBC84E3D7B));
  }
  public IPerParticleFloatInput LocalGravityScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xFE6646FBD7EB148E));
  }
  public IPerParticleFloatInput LocalBuoyancyScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xFE6646FBC6A6171E));
  }
  public IPerParticleVecInput BuoyancyForce {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0xFE6646FBCA7F361E));
  }


}
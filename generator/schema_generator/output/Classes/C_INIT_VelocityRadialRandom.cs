using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_VelocityRadialRandom : CParticleFunctionInitializer, IC_INIT_VelocityRadialRandom {

  public C_INIT_VelocityRadialRandom(nint handle) : base(handle) {
  }

  public C_INIT_VelocityRadialRandom(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x61A3C8D53F31A6BD));
  }
  public IPerParticleFloatInput SpeedMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x61A3C8D5B989E1F8));
  }
  public IPerParticleFloatInput SpeedMax {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x61A3C8D5CF9D8C52));
  }
  public ref Vector LocalCoordinateSystemSpeedScale {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x61A3C8D5CEF062F0));
  }
  public ref bool IgnoreDelta {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x61A3C8D5A944B263));
  }


}
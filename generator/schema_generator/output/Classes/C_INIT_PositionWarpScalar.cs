using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_PositionWarpScalar : CParticleFunctionInitializer, IC_INIT_PositionWarpScalar {

  public C_INIT_PositionWarpScalar(nint handle) : base(handle) {
  }

  public ref Vector WarpMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x36E409431B8A7F09));
  }
  public ref Vector WarpMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x36E409430D76E147));
  }
  public IPerParticleFloatInput InputValue {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x36E4094334445438));
  }
  public ref float PrevPosScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x36E4094346CED122));
  }
  public ref int ScaleControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x36E409439A649261));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x36E409433F31A6BD));
  }


}
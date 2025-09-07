using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_AttractToControlPoint : CParticleFunctionForce, IC_OP_AttractToControlPoint {

  public C_OP_AttractToControlPoint(nint handle) : base(handle) {
  }

  public C_OP_AttractToControlPoint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector ComponentScale {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xBD30C24AB17954E2));
  }
  public IPerParticleFloatInput ForceAmount {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xBD30C24A70831A84));
  }
  public ref float FalloffPower {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBD30C24AE3163382));
  }
  public IParticleTransformInput TransformInput {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0xBD30C24AB3FDC289));
  }
  public IPerParticleFloatInput ForceAmountMin {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xBD30C24AEBB56458));
  }
  public ref bool ApplyMinForce {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBD30C24AF72AC3CC));
  }


}
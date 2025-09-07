using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_CPVelocityForce : CParticleFunctionForce, IC_OP_CPVelocityForce {

  public C_OP_CPVelocityForce(nint handle) : base(handle) {
  }

  public C_OP_CPVelocityForce(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4C04FC843F31A6BD));
  }
  public IPerParticleFloatInput Scale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x4C04FC84B731A42F));
  }


}
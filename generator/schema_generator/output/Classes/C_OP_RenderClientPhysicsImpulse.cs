using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderClientPhysicsImpulse : CParticleFunctionRenderer, IC_OP_RenderClientPhysicsImpulse {

  public C_OP_RenderClientPhysicsImpulse(nint handle) : base(handle) {
  }

  public C_OP_RenderClientPhysicsImpulse(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput Radius {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x618F365ACFC08D));
  }
  public IPerParticleFloatInput Magnitude {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x618F36ED0A1D8B));
  }
  public ref int SimIdFilter {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x618F36C5FA023F));
  }


}
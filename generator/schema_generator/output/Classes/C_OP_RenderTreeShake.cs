using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderTreeShake : CParticleFunctionRenderer, IC_OP_RenderTreeShake {

  public C_OP_RenderTreeShake(nint handle) : base(handle) {
  }

  public ref float PeakStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8EB4A28DA6BB3CD1));
  }
  public IParticleAttributeIndex_t PeakStrengthFieldOverride {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x8EB4A28D78E18331));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8EB4A28D5ACFC08D));
  }
  public IParticleAttributeIndex_t RadiusFieldOverride {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x8EB4A28D53B0BAA1));
  }
  public ref float ShakeDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8EB4A28D941D986F));
  }
  public ref float TransitionTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8EB4A28D8D4BFC39));
  }
  public ref float TwistAmount {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8EB4A28DB299B9CA));
  }
  public ref float RadialAmount {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8EB4A28DA8611998));
  }
  public ref float ControlPointOrientationAmount {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8EB4A28D3D28AFF4));
  }
  public ref int ControlPointForLinearDirection {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8EB4A28D80958783));
  }


}
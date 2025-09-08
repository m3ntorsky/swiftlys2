using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderLightBeam : CParticleFunctionRenderer, IC_OP_RenderLightBeam {

  public C_OP_RenderLightBeam(nint handle) : base(handle) {
  }

  public IParticleCollectionVecInput ColorBlend {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xD8A78450740E9A5F));
  }
  public ref ParticleColorBlendType_t ColorBlendType {
    get => ref _Handle.AsRef<ParticleColorBlendType_t>(Schema.GetOffset(0xD8A78450DBC6EFCF));
  }
  public IParticleCollectionFloatInput BrightnessLumensPerMeter {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xD8A78450889235AE));
  }
  public ref bool CastShadows {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD8A7845036113167));
  }
  public IParticleCollectionFloatInput Skirt {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xD8A78450EAFB6D2A));
  }
  public IParticleCollectionFloatInput Range {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xD8A784503FC92844));
  }
  public IParticleCollectionFloatInput Thickness {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xD8A78450DC7C1987));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderProjected : CParticleFunctionRenderer, IC_OP_RenderProjected {

  public C_OP_RenderProjected(nint handle) : base(handle) {
  }

  public ref bool ProjectCharacter {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA370F307B21A6149));
  }
  public ref bool ProjectWorld {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA370F307078C32D2));
  }
  public ref bool ProjectWater {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA370F3077E2B6E09));
  }
  public ref bool FlipHorizontal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA370F307B0A49AFA));
  }
  public ref bool EnableProjectedDepthControls {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA370F307B614A221));
  }
  public ref float MinProjectionDepth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA370F3076A7B1FB1));
  }
  public ref float MaxProjectionDepth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA370F3078C7219DB));
  }
  public ref CUtlVector ProjectedMaterials {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA370F30718968FAF));
  }
  public IPerParticleFloatInput MaterialSelection {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xA370F3075A88A590));
  }
  public ref float AnimationTimeScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA370F3071CD3BFF4));
  }
  public ref bool OrientToNormal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA370F307FAC0D30A));
  }
  public ref CUtlVector MaterialVars {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA370F307FA861D66));
  }
  public IParticleCollectionFloatInput RadiusScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA370F307A7A20159));
  }
  public IParticleCollectionFloatInput AlphaScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA370F307EC6D3C25));
  }
  public IParticleCollectionFloatInput RollScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xA370F307F2113F72));
  }
  public IParticleAttributeIndex_t Alpha2Field {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xA370F307F60EADC1));
  }
  public IParticleCollectionVecInput ColorScale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xA370F3079F9BB8BA));
  }
  public ref ParticleColorBlendType_t ColorBlendType {
    get => ref _Handle.AsRef<ParticleColorBlendType_t>(Schema.GetOffset(0xA370F307DBC6EFCF));
  }


}
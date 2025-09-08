using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderCables : CParticleFunctionRenderer, IC_OP_RenderCables {

  public C_OP_RenderCables(nint handle) : base(handle) {
  }

  public IParticleCollectionFloatInput RadiusScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x16498877A7A20159));
  }
  public IParticleCollectionFloatInput AlphaScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x16498877EC6D3C25));
  }
  public IParticleCollectionVecInput ColorScale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x164988779F9BB8BA));
  }
  public ref ParticleColorBlendType_t ColorBlendType {
    get => ref _Handle.AsRef<ParticleColorBlendType_t>(Schema.GetOffset(0x16498877DBC6EFCF));
  }
  public CStrongHandle<IInfoForResourceTypeIMaterial2> Material {
    get => new CStrongHandle<InfoForResourceTypeIMaterial2>(_Handle + Schema.GetOffset(0x16498877888CE42E));
  }
  public ref TextureRepetitionMode_t TextureRepetitionMode {
    get => ref _Handle.AsRef<TextureRepetitionMode_t>(Schema.GetOffset(0x164988777CB37DBC));
  }
  public IParticleCollectionFloatInput TextureRepeatsPerSegment {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x164988774C265576));
  }
  public IParticleCollectionFloatInput TextureRepeatsCircumference {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x1649887730DF1DF3));
  }
  public IParticleCollectionFloatInput ColorMapOffsetV {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x164988773012E667));
  }
  public IParticleCollectionFloatInput ColorMapOffsetU {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x164988773112E7FA));
  }
  public IParticleCollectionFloatInput NormalMapOffsetV {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x164988775228495D));
  }
  public IParticleCollectionFloatInput NormalMapOffsetU {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x164988774F2844A4));
  }
  public ref bool DrawCableCaps {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x164988773CBBA5F9));
  }
  public ref float CapRoundness {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x164988775B126564));
  }
  public ref float CapOffsetAmount {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1649887729E8FA5E));
  }
  public ref float TessScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x16498877EE9C9570));
  }
  public ref int MinTesselation {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x16498877ECCEE8B4));
  }
  public ref int MaxTesselation {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x16498877B609C442));
  }
  public ref int Roundness {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1649887761078EC0));
  }
  public IParticleTransformInput LightingTransform {
    get => new CParticleTransformInput(_Handle + Schema.GetOffset(0x164988776557F58F));
  }
  public ref CUtlLeanVector<FloatInputMaterialVariable_t> MaterialFloatVars {
    get => ref _Handle.AsRef<CUtlLeanVector<FloatInputMaterialVariable_t>>(Schema.GetOffset(0x164988777A7B4D6C));
  }
  public ref CUtlLeanVector<VecInputMaterialVariable_t> MaterialVecVars {
    get => ref _Handle.AsRef<CUtlLeanVector<VecInputMaterialVariable_t>>(Schema.GetOffset(0x16498877E670B944));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderTrails : CBaseTrailRenderer, IC_OP_RenderTrails {

  public C_OP_RenderTrails(nint handle) : base(handle) {
  }

  public C_OP_RenderTrails(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool EnableFadingAndClamping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD6B804481BC56ADD));
  }
  public ref float StartFadeDot {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD6B80448A5D81E0E));
  }
  public ref float EndFadeDot {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD6B80448D549B121));
  }
  public IParticleAttributeIndex_t PrevPntSource {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xD6B80448E1E5B3D3));
  }
  public ref float MaxLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD6B8044887A8B4C7));
  }
  public ref float MinLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD6B8044895FB8E51));
  }
  public ref bool IgnoreDT {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD6B80448530C3863));
  }
  public ref float ConstrainRadiusToLengthRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD6B8044892B0E52E));
  }
  public ref float LengthScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD6B80448E312BAFF));
  }
  public ref float LengthFadeInTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD6B80448F2585C63));
  }
  public IPerParticleFloatInput RadiusHeadTaper {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD6B80448FA8DD87B));
  }
  public IParticleCollectionVecInput HeadColorScale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xD6B80448C40BF2F8));
  }
  public IPerParticleFloatInput HeadAlphaScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD6B80448225B27B3));
  }
  public IPerParticleFloatInput RadiusTaper {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD6B804486362520D));
  }
  public IParticleCollectionVecInput TailColorScale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0xD6B80448CA576A18));
  }
  public IPerParticleFloatInput TailAlphaScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xD6B80448E64193A3));
  }
  public IParticleAttributeIndex_t HorizCropField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xD6B8044824C3C3FD));
  }
  public IParticleAttributeIndex_t VertCropField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xD6B804488C72C684));
  }
  public ref float ForwardShift {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD6B80448E6A1E8D8));
  }
  public ref bool FlipUVBasedOnPitchYaw {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD6B8044861C3ACF4));
  }


}
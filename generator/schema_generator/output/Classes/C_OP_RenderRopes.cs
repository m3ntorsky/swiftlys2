using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderRopes : CBaseRendererSource2, IC_OP_RenderRopes {

  public C_OP_RenderRopes(nint handle) : base(handle) {
  }

  public C_OP_RenderRopes(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool EnableFadingAndClamping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9BCDD8B21BC56ADD));
  }
  public ref float MinSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B2BDC3B198));
  }
  public ref float MaxSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B28CA4E6BE));
  }
  public ref float StartFadeSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B2BA251D92));
  }
  public ref float EndFadeSize {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B22D3FD423));
  }
  public ref float StartFadeDot {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B2A5D81E0E));
  }
  public ref float EndFadeDot {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B2D549B121));
  }
  public ref float RadiusTaper {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B26362520D));
  }
  public ref int MinTesselation {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9BCDD8B2ECCEE8B4));
  }
  public ref int MaxTesselation {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9BCDD8B2B609C442));
  }
  public ref float TessScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B2EE9C9570));
  }
  public IParticleCollectionRendererFloatInput TextureVWorldSize {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x9BCDD8B230B8BF35));
  }
  public IParticleCollectionRendererFloatInput TextureVScrollRate {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x9BCDD8B2DC8A591B));
  }
  public IParticleCollectionRendererFloatInput TextureVOffset {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x9BCDD8B21502ED5B));
  }
  public ref int TextureVParamsCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9BCDD8B2264B3E6B));
  }
  public ref bool ClampV {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9BCDD8B2D02C13FE));
  }
  public ref int ScaleCP1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9BCDD8B2B0AB7175));
  }
  public ref int ScaleCP2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9BCDD8B2ADAB6CBC));
  }
  public ref float ScaleVSizeByControlPointDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B22B989321));
  }
  public ref float ScaleVScrollByControlPointDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B2E2B0C749));
  }
  public ref float ScaleVOffsetByControlPointDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B271D6B21B));
  }
  public ref bool UseScalarForTextureCoordinate {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9BCDD8B2BE8C7688));
  }
  public IParticleAttributeIndex_t ScalarFieldForTextureCoordinate {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x9BCDD8B2455C28F7));
  }
  public ref float ScalarAttributeTextureCoordScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BCDD8B279F074DD));
  }
  public ref bool ReverseOrder {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9BCDD8B212C75F97));
  }
  public ref bool ClosedLoop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9BCDD8B27C20D1AB));
  }
  public ref ParticleOrientationChoiceList_t OrientationType {
    get => ref _Handle.AsRef<ParticleOrientationChoiceList_t>(Schema.GetOffset(0x9BCDD8B2931FA045));
  }
  public IParticleAttributeIndex_t VectorFieldForOrientation {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x9BCDD8B2D2DFF7F5));
  }
  public ref bool DrawAsOpaque {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9BCDD8B23556AEE4));
  }
  public ref bool GenerateNormals {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9BCDD8B20FBDD8F6));
  }


}
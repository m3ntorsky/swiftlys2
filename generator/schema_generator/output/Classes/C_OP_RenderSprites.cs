using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderSprites : CBaseRendererSource2, IC_OP_RenderSprites {

  public C_OP_RenderSprites(nint handle) : base(handle) {
  }

  public IParticleCollectionRendererFloatInput SequenceOverride {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x35C7913533862044));
  }
  public ref bool SequenceNumbersAreRawSequenceIndices {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x35C79135306EF03C));
  }
  public ref ParticleOrientationChoiceList_t OrientationType {
    get => ref _Handle.AsRef<ParticleOrientationChoiceList_t>(Schema.GetOffset(0x35C79135931FA045));
  }
  public ref int OrientationControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x35C7913555B5B328));
  }
  public ref bool UseYawWithNormalAligned {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x35C79135A7AF0D54));
  }
  public IParticleCollectionRendererFloatInput MinSize {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x35C79135BDC3B198));
  }
  public IParticleCollectionRendererFloatInput MaxSize {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x35C791358CA4E6BE));
  }
  public IParticleCollectionRendererFloatInput AlphaAdjustWithSizeAdjust {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x35C791355B30C850));
  }
  public IParticleCollectionRendererFloatInput StartFadeSize {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x35C79135BA251D92));
  }
  public IParticleCollectionRendererFloatInput EndFadeSize {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x35C791352D3FD423));
  }
  public ref float StartFadeDot {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x35C79135A5D81E0E));
  }
  public ref float EndFadeDot {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x35C79135D549B121));
  }
  public ref bool DistanceAlpha {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x35C79135CF65F35A));
  }
  public ref bool SoftEdges {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x35C791354D56D8CD));
  }
  public ref float EdgeSoftnessStart {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x35C7913583B977AF));
  }
  public ref float EdgeSoftnessEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x35C79135801CC13A));
  }
  public ref bool Outline {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x35C79135E5CA479D));
  }
  public ref Color OutlineColor {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x35C7913575B94BB0));
  }
  public ref int OutlineAlpha {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x35C79135290C6707));
  }
  public ref float OutlineStart0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x35C7913500B6410B));
  }
  public ref float OutlineStart1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x35C79135FFB63F78));
  }
  public ref float OutlineEnd0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x35C79135D8EF5788));
  }
  public ref float OutlineEnd1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x35C79135D9EF591B));
  }
  public ref ParticleLightingQuality_t LightingMode {
    get => ref _Handle.AsRef<ParticleLightingQuality_t>(Schema.GetOffset(0x35C791359C9B184A));
  }
  public IParticleCollectionRendererFloatInput LightingTessellation {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x35C791354CFEA24E));
  }
  public IParticleCollectionRendererFloatInput LightingDirectionality {
    get => new CParticleCollectionRendererFloatInput(_Handle + Schema.GetOffset(0x35C7913575690583));
  }
  public ref bool ParticleShadows {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x35C7913544427B1C));
  }
  public ref float ShadowDensity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x35C791352B024AE9));
  }
  public IReplicationParameters ReplicationParameters {
    get => new CReplicationParameters(_Handle + Schema.GetOffset(0x35C79135C63216ED));
  }


}
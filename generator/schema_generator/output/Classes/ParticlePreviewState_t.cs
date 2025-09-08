using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParticlePreviewState_t : SchemaClass, IParticlePreviewState_t {

  public ParticlePreviewState_t(nint handle) : base(handle) {
  }

  public ref CUtlString PreviewModel {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x31FB1901BC4FDC14));
  }
  public ref uint ModSpecificData {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x31FB19011580A6CB));
  }
  public ref PetGroundType_t GroundType {
    get => ref _Handle.AsRef<PetGroundType_t>(Schema.GetOffset(0x31FB190132DE357E));
  }
  public ref CUtlString SequenceName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x31FB19012B4A24CB));
  }
  public ref int FireParticleOnSequenceFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x31FB19014432CB48));
  }
  public ref CUtlString HitboxSetName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x31FB19011ACA1CAE));
  }
  public ref CUtlString MaterialGroupName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x31FB1901A6930C68));
  }
  public ref CUtlVector BodyGroups {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x31FB1901893FA01D));
  }
  public ref float PlaybackSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x31FB1901FA2B402D));
  }
  public ref float ParticleSimulationRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x31FB1901F9FAF9E0));
  }
  public ref bool ShouldDrawHitboxes {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x31FB19016D95117E));
  }
  public ref bool ShouldDrawAttachments {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x31FB19014EC43A36));
  }
  public ref bool ShouldDrawAttachmentNames {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x31FB1901177CB28B));
  }
  public ref bool ShouldDrawControlPointAxes {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x31FB1901A6A34D38));
  }
  public ref bool AnimationNonLooping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x31FB1901F0071FD6));
  }
  public ref Vector PreviewGravity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x31FB1901A6B7913F));
  }


}
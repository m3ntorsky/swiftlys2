using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmParticleEvent : CNmEvent, INmParticleEvent {

  public CNmParticleEvent(nint handle) : base(handle) {
  }

  public ref CNmEventRelevance_t Relevance {
    get => ref _Handle.AsRef<CNmEventRelevance_t>(Schema.GetOffset(0x441D270F1E3F4008));
  }
  public ref CNmParticleEvent::Type_t Type {
    get => ref _Handle.AsRef<CNmParticleEvent::Type_t>(Schema.GetOffset(0x441D270F0F04B4ED));
  }
  public CStrongHandle<IInfoForResourceTypeIParticleSystemDefinition> ParticleSystem {
    get => new CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>(_Handle + Schema.GetOffset(0x441D270FC9C33AF8));
  }
  public ref CUtlString Tags {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x441D270FB46C8540));
  }
  public ref bool StopImmediately {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x441D270FB16078E1));
  }
  public ref CUtlString AttachmentPoint0 {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x441D270FBFDCDF8A));
  }
  public ref ParticleAttachment_t AttachmentType0 {
    get => ref _Handle.AsRef<ParticleAttachment_t>(Schema.GetOffset(0x441D270F63E9B990));
  }
  public ref CUtlString AttachmentPoint1 {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x441D270FC0DCE11D));
  }
  public ref ParticleAttachment_t AttachmentType1 {
    get => ref _Handle.AsRef<ParticleAttachment_t>(Schema.GetOffset(0x441D270F64E9BB23));
  }
  public ref CUtlString Config {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x441D270FD8B39967));
  }
  public ref CUtlString EffectForConfig {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x441D270FA68959D9));
  }
  public ref bool DetachFromOwner {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x441D270F357F7C69));
  }
  public ref bool PlayEndCap {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x441D270FA7AB4A38));
  }


}
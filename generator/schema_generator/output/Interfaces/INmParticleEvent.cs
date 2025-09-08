using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmParticleEvent : INmEvent {

  public ref CNmEventRelevance_t Relevance { get; }
  
  public ref CNmParticleEvent::Type_t Type { get; }
  
  public CStrongHandle<IInfoForResourceTypeIParticleSystemDefinition> ParticleSystem { get; }
  
  public ref CUtlString Tags { get; }
  
  public ref bool StopImmediately { get; }
  
  public ref CUtlString AttachmentPoint0 { get; }
  
  public ref ParticleAttachment_t AttachmentType0 { get; }
  
  public ref CUtlString AttachmentPoint1 { get; }
  
  public ref ParticleAttachment_t AttachmentType1 { get; }
  
  public ref CUtlString Config { get; }
  
  public ref CUtlString EffectForConfig { get; }
  
  public ref bool DetachFromOwner { get; }
  
  public ref bool PlayEndCap { get; }
  
}
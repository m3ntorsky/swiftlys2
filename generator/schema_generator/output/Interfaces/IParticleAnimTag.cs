using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleAnimTag : IAnimTagBase {

  
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> ParticleSystem { get; }
  
  public ref CUtlString ParticleSystemName { get; }
  
  public ref CUtlString ConfigName { get; }
  
  public ref bool DetachFromOwner { get; }
  
  public ref bool Aggregate { get; }
  
  public ref bool StopWhenTagEnds { get; }
  
  public ref bool TagEndStopIsInstant { get; }
  
  public ref CUtlString AttachmentName { get; }
  
  public ref ParticleAttachment_t AttachmentType { get; }
  
  public ref CUtlString AttachmentCP1Name { get; }
  
  public ref ParticleAttachment_t AttachmentCP1Type { get; }
}
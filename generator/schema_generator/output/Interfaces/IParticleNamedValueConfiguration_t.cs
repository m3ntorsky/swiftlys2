using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleNamedValueConfiguration_t : ISchemaClass {

  public ref CUtlString ConfigName { get; }
  
  public ISchemaUntypedField ConfigValue { get; }
  
  public ref ParticleAttachment_t AttachType { get; }
  
  public ref CUtlString BoundEntityPath { get; }
  
  public ref CUtlString StrEntityScope { get; }
  
  public ref CUtlString StrAttachmentName { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleControlPointDriver_t : ISchemaClass {

  
  public ref int ControlPoint { get; }
  
  public ref ParticleAttachment_t AttachType { get; }
  
  public ref CUtlString AttachmentName { get; }
  
  public ref Vector Offset { get; }
  
  public ref QAngle Offset { get; }
  
  public ref CUtlString EntityName { get; }
}
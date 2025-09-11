using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundEventSphereEntity : ISoundEventEntity {

  
  public ref float Radius { get; }
}
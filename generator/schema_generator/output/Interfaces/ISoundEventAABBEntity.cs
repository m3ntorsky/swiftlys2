using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundEventAABBEntity : ISoundEventEntity {

  public ref Vector Mins { get; }
  
  public ref Vector Maxs { get; }
  
}
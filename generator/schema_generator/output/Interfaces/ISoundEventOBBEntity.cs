using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundEventOBBEntity : ISoundEventEntity {

  
  public ref Vector Mins { get; }
  
  public ref Vector Maxs { get; }
}
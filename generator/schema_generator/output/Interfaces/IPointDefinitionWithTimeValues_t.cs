using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointDefinitionWithTimeValues_t : IPointDefinition_t {

  public ref float TimeDuration { get; }
  
}
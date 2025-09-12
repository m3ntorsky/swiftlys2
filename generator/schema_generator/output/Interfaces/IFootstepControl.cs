using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootstepControl : IBaseTrigger {

  
  public ISchemaUntypedField Source { get; }
  
  public ISchemaUntypedField Destination { get; }
}
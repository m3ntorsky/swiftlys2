using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INavGravity_t : ISchemaClass {

  
  public ref Vector Gravity { get; }
  
  public ref bool Default { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootMotion : ISchemaClass {

  public ref CUtlVector Strides { get; }
  
  public ref CUtlString Name { get; }
  
  public ref bool Additive { get; }
  
}
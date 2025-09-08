using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICycleBase : ISchemaClass {

  public ref float Cycle { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IProductQuantizer : ISchemaClass {

  
// CUtlVector< CVectorQuantizer >
  public ref CUtlVector SubQuantizers { get; }
  
  public ref int Dimensions { get; }
}
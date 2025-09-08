using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IResponseCriteriaSet : ISchemaClass {

  public ref int NumPrefixedContexts { get; }
  
  public ref bool OverrideOnAppend { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Inflow_Method : IPulseCell_Inflow_BaseEntrypoint {

  
  public ISchemaUntypedField MethodName { get; }
  
  public ref CUtlString Description { get; }
  
  public ref bool IsPublic { get; }
  
  public ISchemaUntypedField ReturnType { get; }
  
  public ref CUtlLeanVector<CPulseRuntimeMethodArg> Args { get; }
}
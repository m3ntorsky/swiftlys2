using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFunctionInfo_t : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public ref CUtlStringToken NameToken { get; }
  
  public ref int ParamCount { get; }
  
  public IFuseFunctionIndex_t Index { get; }
  
  public ref bool IsPure { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuseSymbolTable : ISchemaClass {

  
// CUtlVector< ConstantInfo_t >
  public ref CUtlVector Constants { get; }
  
// CUtlVector< VariableInfo_t >
  public ref CUtlVector Variables { get; }
  
// CUtlVector< FunctionInfo_t >
  public ref CUtlVector Functions { get; }
  
  public ISchemaUntypedField ConstantMap { get; }
  
  public ISchemaUntypedField VariableMap { get; }
  
  public ISchemaUntypedField FunctionMap { get; }
}
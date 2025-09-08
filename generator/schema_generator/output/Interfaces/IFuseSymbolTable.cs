using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuseSymbolTable : ISchemaClass {

  public ref CUtlVector Constants { get; }
  
  public ref CUtlVector Variables { get; }
  
  public ref CUtlVector Functions { get; }
  
  public ISchemaUntypedField ConstantMap { get; }
  
  public ISchemaUntypedField VariableMap { get; }
  
  public ISchemaUntypedField FunctionMap { get; }
  
}
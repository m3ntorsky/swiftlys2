using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimParameterManagerUpdater : ISchemaClass {

  public ref CUtlVector Parameters { get; }
  
  public ISchemaUntypedField IdToIndexMap { get; }
  
  public ISchemaUntypedField NameToIndexMap { get; }
  
  public ref CUtlVector IndexToHandle { get; }
  
  public ref CUtlVector AutoResetParams { get; }
  
  public ISchemaUntypedField AutoResetMap { get; }
  
}
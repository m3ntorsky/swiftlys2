using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimParameterManagerUpdater : ISchemaClass {

  
// CUtlVector< CSmartPtr< CAnimParameterBase > >
  public ref CUtlVector Parameters { get; }
  
  public ISchemaUntypedField IdToIndexMap { get; }
  
  public ISchemaUntypedField NameToIndexMap { get; }
  
// CUtlVector< CAnimParamHandle >
  public ref CUtlVector IndexToHandle { get; }
  
// CUtlVector< std::pair< CAnimParamHandle, CAnimVariant > >
  public ref CUtlVector AutoResetParams { get; }
  
  public ISchemaUntypedField AutoResetMap { get; }
}
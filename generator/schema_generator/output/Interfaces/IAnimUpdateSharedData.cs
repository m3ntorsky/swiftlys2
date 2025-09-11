using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimUpdateSharedData : ISchemaClass {

  
// CUtlVector< CSmartPtr< CAnimUpdateNodeBase > >
  public ref CUtlVector Nodes { get; }
  
  public ISchemaUntypedField NodeIndexMap { get; }
  
// CUtlVector< CSmartPtr< CAnimComponentUpdater > >
  public ref CUtlVector Components { get; }
  
  public ISchemaUntypedField ParamListUpdater { get; }
  
  public ISchemaUntypedField TagManagerUpdater { get; }
  
  public ISchemaUntypedField ScriptManager { get; }
  
  public IAnimGraphSettingsManager Settings { get; }
  
  public ISchemaUntypedField StaticPoseCache { get; }
  
  public ISchemaUntypedField Skeleton { get; }
  
  public IAnimNodePath RootNodePath { get; }
}
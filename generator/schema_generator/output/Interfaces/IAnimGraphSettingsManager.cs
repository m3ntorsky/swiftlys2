using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimGraphSettingsManager : ISchemaClass {

  
// CUtlVector< CSmartPtr< CAnimGraphSettingsGroup > >
  public ref CUtlVector SettingsGroups { get; }
}
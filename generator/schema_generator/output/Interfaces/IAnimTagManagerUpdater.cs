using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimTagManagerUpdater : ISchemaClass {

  
// CUtlVector< CSmartPtr< CAnimTagBase > >
  public ref CUtlVector Tags { get; }
}
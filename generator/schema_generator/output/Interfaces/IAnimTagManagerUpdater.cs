using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimTagManagerUpdater : ISchemaClass {

  public ref CUtlVector Tags { get; }
  
}
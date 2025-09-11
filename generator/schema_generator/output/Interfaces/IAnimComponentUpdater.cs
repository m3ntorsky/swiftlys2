using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimComponentUpdater : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public IAnimComponentID Id { get; }
  
  public ref AnimNodeNetworkMode NetworkMode { get; }
  
  public ref bool StartEnabled { get; }
}
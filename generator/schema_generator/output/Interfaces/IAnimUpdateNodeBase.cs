using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimUpdateNodeBase : ISchemaClass {

  public IAnimNodePath NodePath { get; }
  
  public ref AnimNodeNetworkMode NetworkMode { get; }
  
  public ref CUtlString Name { get; }
  
}
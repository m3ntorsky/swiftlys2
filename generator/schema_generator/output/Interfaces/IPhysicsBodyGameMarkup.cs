using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysicsBodyGameMarkup : ISchemaClass {

  public ref CUtlString TargetBody { get; }
  
  public ref CGlobalSymbol Tag { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHitBoxSet : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref uint NameHash { get; }
  
// CUtlVector< CHitBox >
  public ref CUtlVector HitBoxes { get; }
  
  public ref CUtlString SourceFilename { get; }
}
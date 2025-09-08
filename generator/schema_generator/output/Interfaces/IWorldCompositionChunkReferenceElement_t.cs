using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWorldCompositionChunkReferenceElement_t : ISchemaClass {

  public ref CUtlString StrMapToLoad { get; }
  
  public ref CUtlString StrLandmarkName { get; }
  
}
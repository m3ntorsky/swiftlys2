using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeVertexMapBuildArray : ISchemaClass {

  public ref CUtlVector<PointerTo<FeVertexMapBuild_t>> Array { get; }
  
}
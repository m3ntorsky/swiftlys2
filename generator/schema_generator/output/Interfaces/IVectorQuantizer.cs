using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVectorQuantizer : ISchemaClass {

  public ref CUtlVector<float> CentroidVectors { get; }
  
  public ref int Centroids { get; }
  
  public ref int Dimensions { get; }
  
}
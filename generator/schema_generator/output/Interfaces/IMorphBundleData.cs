using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMorphBundleData : ISchemaClass {

  public ref float ULeftSrc { get; }
  
  public ref float VTopSrc { get; }
  
  public ref CUtlVector<float> Offsets { get; }
  
  public ref CUtlVector<float> Ranges { get; }
  
}
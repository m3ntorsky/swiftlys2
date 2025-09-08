using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkeletonBoneBounds_t : ISchemaClass {

  public ref Vector Center { get; }
  
  public ref Vector Size { get; }
  
}
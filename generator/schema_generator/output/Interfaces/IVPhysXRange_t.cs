using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVPhysXRange_t : ISchemaClass {

  
  public ref float Min { get; }
  
  public ref float Max { get; }
}
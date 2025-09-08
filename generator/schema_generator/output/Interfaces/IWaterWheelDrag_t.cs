using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWaterWheelDrag_t : ISchemaClass {

  public ref float FractionOfWheelSubmerged { get; }
  
  public ref float WheelDrag { get; }
  
}
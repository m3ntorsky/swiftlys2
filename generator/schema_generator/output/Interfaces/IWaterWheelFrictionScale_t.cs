using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWaterWheelFrictionScale_t : ISchemaClass {

  public ref float FractionOfWheelSubmerged { get; }
  
  public ref float FrictionScale { get; }
  
}
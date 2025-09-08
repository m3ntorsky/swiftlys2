using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotorController : ISchemaClass {

  public ref float Speed { get; }
  
  public ref float MaxTorque { get; }
  
  public ref Vector Axis { get; }
  
  public ref float InertiaFactor { get; }
  
}
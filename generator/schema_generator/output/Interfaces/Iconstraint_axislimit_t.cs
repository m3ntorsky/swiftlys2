using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Iconstraint_axislimit_t : ISchemaClass {

  public ref float MinRotation { get; }
  
  public ref float MaxRotation { get; }
  
  public ref float MotorTargetAngSpeed { get; }
  
  public ref float MotorMaxTorque { get; }
  
}
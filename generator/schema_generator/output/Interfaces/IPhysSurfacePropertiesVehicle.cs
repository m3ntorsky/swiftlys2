using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysSurfacePropertiesVehicle : ISchemaClass {

  
  public ref float WheelDrag { get; }
  
  public ref float WheelFrictionScale { get; }
}
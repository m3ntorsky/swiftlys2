using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysPulley : IPhysConstraint {

  
  public ref Vector Position2 { get; }
  
  public ISchemaFixedArray<Vector> Offset { get; }
  
  public ref float AddLength { get; }
  
  public ref float GearRatio { get; }
}
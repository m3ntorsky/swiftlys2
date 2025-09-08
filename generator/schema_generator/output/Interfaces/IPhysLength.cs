using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysLength : IPhysConstraint {

  public ISchemaFixedArray<Vector> Offset { get; }
  
  public ref Vector Attach { get; }
  
  public ref float AddLength { get; }
  
  public ref float MinLength { get; }
  
  public ref float TotalLength { get; }
  
  public ref bool EnableCollision { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootTrajectory : ISchemaClass {

  
  public ref Vector Offset { get; }
  
  public ref float RotationOffset { get; }
  
  public ref float Progression { get; }
}
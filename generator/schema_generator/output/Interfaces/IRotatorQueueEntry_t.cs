using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRotatorQueueEntry_t : ISchemaClass {

  public ref Quaternion Target { get; }
  
  public ref RotatorTargetSpace_t Space { get; }
  
}
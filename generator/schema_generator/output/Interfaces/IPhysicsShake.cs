using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysicsShake : ISchemaClass {

  public ref Vector Force { get; }
  
}
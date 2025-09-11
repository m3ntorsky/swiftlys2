using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRagdollCreationParams_t : ISchemaClass {

  
  public ref Vector Force { get; }
  
  public ref int ForceBone { get; }
  
  public ref bool ForceCurrentWorldTransform { get; }
  
  public ref bool UseLRURetirement { get; }
  
  public ref int HealthToGrant { get; }
}
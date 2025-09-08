using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimInputDamping : ISchemaClass {

  public ref DampingSpeedFunction SpeedFunction { get; }
  
  public ref float SpeedScale { get; }
  
  public ref float FallingSpeedScale { get; }
  
}
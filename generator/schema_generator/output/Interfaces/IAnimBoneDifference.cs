using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimBoneDifference : ISchemaClass {

  public ref CBufferString Name { get; }
  
  public ref CBufferString Parent { get; }
  
  public ref Vector PosError { get; }
  
  public ref bool HasRotation { get; }
  
  public ref bool HasMovement { get; }
  
}
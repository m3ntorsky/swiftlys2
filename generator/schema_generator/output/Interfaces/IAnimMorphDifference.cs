using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimMorphDifference : ISchemaClass {

  
  public ref CBufferString Name { get; }
}
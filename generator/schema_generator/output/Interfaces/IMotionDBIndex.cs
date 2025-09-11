using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionDBIndex : ISchemaClass {

  
  public ref uint Index { get; }
}
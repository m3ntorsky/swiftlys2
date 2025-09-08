using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionBlendItem : ISchemaClass {

  public ISchemaUntypedField Child { get; }
  
  public ref float KeyValue { get; }
  
}
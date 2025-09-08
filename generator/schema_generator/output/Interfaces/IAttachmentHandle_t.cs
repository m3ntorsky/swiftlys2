using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAttachmentHandle_t : ISchemaClass {

  public ref byte Value { get; }
  
}
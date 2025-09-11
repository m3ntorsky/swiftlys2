using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRenderInputLayoutField_t : ISchemaClass {

  
  public ISchemaFixedString SemanticName { get; }
  
  public ref byte SemanticIndex { get; }
  
  public ref short Offset { get; }
  
  public ref byte Slot { get; }
  
  public ref RenderSlotType_t SlotType { get; }
  
  public ISchemaFixedString ShaderSemantic { get; }
}
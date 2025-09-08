using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmGraphDefinition__ReferencedGraphSlot_t : ISchemaClass {

  public ref short NodeIdx { get; }
  
  public ref short DataSlotIdx { get; }
  
}
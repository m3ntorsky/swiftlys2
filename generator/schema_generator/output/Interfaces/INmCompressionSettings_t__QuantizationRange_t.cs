using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmCompressionSettings_t__QuantizationRange_t : ISchemaClass {

  
  public ref float RangeStart { get; }
  
  public ref float RangeLength { get; }
}
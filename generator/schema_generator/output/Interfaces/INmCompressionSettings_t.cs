using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmCompressionSettings_t : ISchemaClass {

  
  public INmCompressionSettings_t::QuantizationRange_t TranslationRangeX { get; }
  
  public INmCompressionSettings_t::QuantizationRange_t TranslationRangeY { get; }
  
  public INmCompressionSettings_t::QuantizationRange_t TranslationRangeZ { get; }
  
  public INmCompressionSettings_t::QuantizationRange_t ScaleRange { get; }
  
  public ref Quaternion ConstantRotation { get; }
  
  public ref bool IsRotationStatic { get; }
  
  public ref bool IsTranslationStatic { get; }
  
  public ref bool IsScaleStatic { get; }
}
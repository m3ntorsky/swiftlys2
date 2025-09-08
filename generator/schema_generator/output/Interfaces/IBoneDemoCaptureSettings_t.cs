using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBoneDemoCaptureSettings_t : ISchemaClass {

  public ref CUtlString BoneName { get; }
  
  public ref float ErrorSplineRotationMax { get; }
  
  public ref float ErrorSplineTranslationMax { get; }
  
  public ref float ErrorSplineScaleMax { get; }
  
  public ref float ErrorQuantizationRotationMax { get; }
  
  public ref float ErrorQuantizationTranslationMax { get; }
  
  public ref float ErrorQuantizationScaleMax { get; }
  
}
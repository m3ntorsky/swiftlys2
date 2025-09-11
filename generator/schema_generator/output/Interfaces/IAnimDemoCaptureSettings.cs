using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimDemoCaptureSettings : ISchemaClass {

  
  public ref Vector2D ErrorRangeSplineRotation { get; }
  
  public ref Vector2D ErrorRangeSplineTranslation { get; }
  
  public ref Vector2D ErrorRangeSplineScale { get; }
  
  public ref float IkRotation_MaxSplineError { get; }
  
  public ref float IkTranslation_MaxSplineError { get; }
  
  public ref Vector2D ErrorRangeQuantizationRotation { get; }
  
  public ref Vector2D ErrorRangeQuantizationTranslation { get; }
  
  public ref Vector2D ErrorRangeQuantizationScale { get; }
  
  public ref float IkRotation_MaxQuantizationError { get; }
  
  public ref float IkTranslation_MaxQuantizationError { get; }
  
  public ref CUtlString BaseSequence { get; }
  
  public ref int BaseSequenceFrame { get; }
  
  public ref EDemoBoneSelectionMode BoneSelectionMode { get; }
  
// CUtlVector< BoneDemoCaptureSettings_t >
  public ref CUtlVector Bones { get; }
  
// CUtlVector< IKDemoCaptureSettings_t >
  public ref CUtlVector IkChains { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMoodAnimationLayer_t : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref bool ActiveListening { get; }
  
  public ref bool ActiveTalking { get; }
  
// CUtlVector< MoodAnimation_t >
  public ref CUtlVector LayerAnimations { get; }
  
  public IRangeFloat Intensity { get; }
  
  public IRangeFloat DurationScale { get; }
  
  public ref bool ScaleWithInts { get; }
  
  public IRangeFloat NextStart { get; }
  
  public IRangeFloat StartOffset { get; }
  
  public IRangeFloat EndOffset { get; }
  
  public ref float FadeIn { get; }
  
  public ref float FadeOut { get; }
}
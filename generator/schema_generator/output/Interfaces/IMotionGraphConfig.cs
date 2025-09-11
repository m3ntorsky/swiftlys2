using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionGraphConfig : ISchemaClass {

  
  public ISchemaFixedArray<float> ParamValues { get; }
  
  public ref float Duration { get; }
  
  public IMotionIndex MotionIndex { get; }
  
  public ref int SampleStart { get; }
  
  public ref int SampleCount { get; }
}
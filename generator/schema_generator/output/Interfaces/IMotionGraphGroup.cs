using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionGraphGroup : ISchemaClass {

  public IMotionSearchDB SearchDB { get; }
  
  public ref CUtlVector MotionGraphs { get; }
  
  public ref CUtlVector MotionGraphConfigs { get; }
  
  public ref CUtlVector<int> SampleToConfig { get; }
  
  public IAnimScriptHandle IsActiveScript { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionGraphGroup : ISchemaClass {

  
  public IMotionSearchDB SearchDB { get; }
  
// CUtlVector< CSmartPtr< CMotionGraph > >
  public ref CUtlVector MotionGraphs { get; }
  
// CUtlVector< CMotionGraphConfig >
  public ref CUtlVector MotionGraphConfigs { get; }
  
  public ref CUtlVector<int> SampleToConfig { get; }
  
  public IAnimScriptHandle IsActiveScript { get; }
}
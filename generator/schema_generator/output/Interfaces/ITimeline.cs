using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITimeline : IIntervalTimer {

  public ISchemaFixedArray<float> Values { get; }
  
  public ISchemaFixedArray<int> ValueCounts { get; }
  
  public ref int BucketCount { get; }
  
  public ref float Interval { get; }
  
  public ref float FinalValue { get; }
  
  public ref TimelineCompression_t CompressionType { get; }
  
  public ref bool Stopped { get; }
  
}
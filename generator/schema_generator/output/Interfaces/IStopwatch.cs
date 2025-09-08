using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStopwatch : IStopwatchBase {

  public ref float Interval { get; }
  
}
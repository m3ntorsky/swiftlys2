using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStopwatchBase : ISimpleSimTimer {

  
  public ref bool IsRunning { get; }
}
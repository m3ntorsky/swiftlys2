using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_IntervalTimer__CursorState_t : ISchemaClass {

  public IGameTime_t StartTime { get; }
  
  public IGameTime_t EndTime { get; }
  
  public ref float WaitInterval { get; }
  
  public ref float WaitIntervalHigh { get; }
  
  public ref bool CompleteOnNextWake { get; }
  
}
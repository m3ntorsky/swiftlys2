using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEventAdvanceTick_t : IEventSimulate_t {

  public ref int CurrentTick { get; }
  
  public ref int CurrentTickThisFrame { get; }
  
  public ref int TotalTicksThisFrame { get; }
  
  public ref int TotalTicks { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_WaitForCursorsWithTag : IPulseCell_WaitForCursorsWithTagBase {

  
  public ref bool TagSelfWhenComplete { get; }
  
  public ref PulseCursorCancelPriority_t DesiredKillPriority { get; }
}
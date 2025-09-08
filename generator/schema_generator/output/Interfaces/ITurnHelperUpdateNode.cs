using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITurnHelperUpdateNode : IUnaryUpdateNode {

  public ref AnimValueSource FacingTarget { get; }
  
  public ref float TurnStartTimeOffset { get; }
  
  public ref float TurnDuration { get; }
  
  public ref bool MatchChildDuration { get; }
  
  public ref float ManualTurnOffset { get; }
  
  public ref bool UseManualTurnOffset { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicAutosave : ILogicalEntity {

  
  public ref bool ForceNewLevelUnit { get; }
  
  public ref int MinHitPoints { get; }
  
  public ref int MinHitPointsToCommit { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicDistanceAutosave : ILogicalEntity {

  public ref CUtlSymbolLarge TargetEntity { get; }
  
  public ref float DistanceToPlayer { get; }
  
  public ref bool ForceNewLevelUnit { get; }
  
  public ref bool CheckCough { get; }
  
  public ref bool ThinkDangerous { get; }
  
  public ref float DangerousTime { get; }
  
}
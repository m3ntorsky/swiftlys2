using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayerResource : IBaseEntity {

  
  public ISchemaFixedArray<bool> HostageAlive { get; }
  
  public ISchemaFixedArray<bool> IsHostageFollowingSomeone { get; }
  
  public ISchemaFixedArray<CEntityIndex> HostageEntityIDs { get; }
  
  public ref Vector BombsiteCenterA { get; }
  
  public ref Vector BombsiteCenterB { get; }
  
  public ISchemaFixedArray<int> HostageRescueX { get; }
  
  public ISchemaFixedArray<int> HostageRescueY { get; }
  
  public ISchemaFixedArray<int> HostageRescueZ { get; }
  
  public ref bool EndMatchNextMapAllVoted { get; }
  
  public ref bool FoundGoalPositions { get; }
}
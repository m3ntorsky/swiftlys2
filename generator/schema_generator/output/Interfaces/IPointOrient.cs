using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointOrient : IBaseEntity {

  public ref CUtlSymbolLarge SpawnTargetName { get; }
  
  public CHandle<IBaseEntity> Target { get; }
  
  public ref bool Active { get; }
  
  public ref PointOrientGoalDirectionType_t GoalDirection { get; }
  
  public ref PointOrientConstraint_t Constraint { get; }
  
  public ref float MaxTurnRate { get; }
  
  public IGameTime_t LastGameTime { get; }
  
}
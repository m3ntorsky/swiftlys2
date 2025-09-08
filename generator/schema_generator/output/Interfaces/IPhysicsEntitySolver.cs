using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysicsEntitySolver : ILogicalEntity {

  public ref CHandle<CBaseEntity> MovingEntity { get; }
  
  public ref CHandle<CBaseEntity> PhysicsBlocker { get; }
  
  public ref float SeparationDuration { get; }
  
  public IGameTime_t CancelTime { get; }
  
}
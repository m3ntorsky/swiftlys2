using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysicsEntitySolver : ILogicalEntity {

  public CHandle<IBaseEntity> MovingEntity { get; }
  
  public CHandle<IBaseEntity> PhysicsBlocker { get; }
  
  public ref float SeparationDuration { get; }
  
  public IGameTime_t CancelTime { get; }
  
}
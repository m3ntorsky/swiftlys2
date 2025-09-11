using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IItem : IBaseAnimGraph {

  
  public IEntityIOOutput OnPlayerTouch { get; }
  
  public IEntityIOOutput OnPlayerPickup { get; }
  
  public ref bool ActivateWhenAtRest { get; }
  
  public IEntityIOOutput OnCacheInteraction { get; }
  
  public IEntityIOOutput OnGlovePulled { get; }
  
  public ref Vector OriginalSpawnOrigin { get; }
  
  public ref QAngle OriginalSpawnAngles { get; }
  
  public ref bool PhysStartAsleep { get; }
}
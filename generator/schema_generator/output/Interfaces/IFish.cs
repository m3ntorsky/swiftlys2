using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFish : IBaseAnimGraph {

  
  public ref CHandle<CFishPool> Pool { get; }
  
  public ref uint Id { get; }
  
  public ref float X { get; }
  
  public ref float Y { get; }
  
  public ref float Z { get; }
  
  public ref float Angle { get; }
  
  public ref float AngleChange { get; }
  
  public ref Vector Forward { get; }
  
  public ref Vector Perp { get; }
  
  public ref Vector PoolOrigin { get; }
  
  public ref float WaterLevel { get; }
  
  public ref float Speed { get; }
  
  public ref float DesiredSpeed { get; }
  
  public ref float CalmSpeed { get; }
  
  public ref float PanicSpeed { get; }
  
  public ref float AvoidRange { get; }
  
  public ICountdownTimer TurnTimer { get; }
  
  public ref bool TurnClockwise { get; }
  
  public ICountdownTimer GoTimer { get; }
  
  public ICountdownTimer MoveTimer { get; }
  
  public ICountdownTimer PanicTimer { get; }
  
  public ICountdownTimer DisperseTimer { get; }
  
  public ICountdownTimer ProximityTimer { get; }
  
  public ref CUtlVector<PointerTo<CFish>> Visible { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvShake : IPointEntity {

  
  public ref CUtlSymbolLarge LimitToEntity { get; }
  
  public ref float Amplitude { get; }
  
  public ref float Frequency { get; }
  
  public ref float Duration { get; }
  
  public ref float Radius { get; }
  
  public IGameTime_t StopTime { get; }
  
  public IGameTime_t NextShake { get; }
  
  public ref float CurrentAmp { get; }
  
  public ref Vector MaxForce { get; }
  
  public IPhysicsShake ShakeCallback { get; }
}
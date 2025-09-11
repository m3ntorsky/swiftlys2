using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerLook : ITriggerOnce {

  
  public ref CHandle<CBaseEntity> LookTarget { get; }
  
  public ref float FieldOfView { get; }
  
  public ref float LookTime { get; }
  
  public ref float LookTimeTotal { get; }
  
  public IGameTime_t LookTimeLast { get; }
  
  public ref float TimeoutDuration { get; }
  
  public ref bool TimeoutFired { get; }
  
  public ref bool IsLooking { get; }
  
  public ref bool B2DFOV { get; }
  
  public ref bool UseVelocity { get; }
  
  public ref bool TestOcclusion { get; }
  
  public ref bool TestAllVisibleOcclusion { get; }
  
  public IEntityIOOutput OnTimeout { get; }
  
  public IEntityIOOutput OnStartLook { get; }
  
  public IEntityIOOutput OnEndLook { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBtActionMoveTo : IBtNode {

  public ref CUtlString DestinationInputKey { get; }
  
  public ref CUtlString HidingSpotInputKey { get; }
  
  public ref CUtlString ThreatInputKey { get; }
  
  public ref Vector Destination { get; }
  
  public ref bool AutoLookAdjust { get; }
  
  public ref bool ComputePath { get; }
  
  public ref float DamagingAreasPenaltyCost { get; }
  
  public ICountdownTimer CheckApproximateCornersTimer { get; }
  
  public ICountdownTimer CheckHighPriorityItem { get; }
  
  public ICountdownTimer RepathTimer { get; }
  
  public ref float ArrivalEpsilon { get; }
  
  public ref float AdditionalArrivalEpsilon2D { get; }
  
  public ref float HidingSpotCheckDistanceThreshold { get; }
  
  public ref float NearestAreaDistanceThreshold { get; }
  
}
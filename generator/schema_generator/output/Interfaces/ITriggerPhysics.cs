using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerPhysics : IBaseTrigger {

  
  public ref float GravityScale { get; }
  
  public ref float LinearLimit { get; }
  
  public ref float LinearDamping { get; }
  
  public ref float AngularLimit { get; }
  
  public ref float AngularDamping { get; }
  
  public ref float LinearForce { get; }
  
  public ref float Frequency { get; }
  
  public ref float DampingRatio { get; }
  
  public ref Vector LinearForcePointAt { get; }
  
  public ref bool CollapseToForcePoint { get; }
  
  public ref Vector LinearForcePointAtWorld { get; }
  
  public ref Vector LinearForceDirection { get; }
  
  public ref bool ConvertToDebrisWhenPossible { get; }
}
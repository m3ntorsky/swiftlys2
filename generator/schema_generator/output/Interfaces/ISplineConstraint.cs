using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISplineConstraint : IPhysConstraint {

  public ref Vector AnchorOffsetRestore { get; }
  
  public ref CHandle<CBaseEntity> SplineEntity { get; }
  
  public ref bool EnableLateralConstraint { get; }
  
  public ref bool EnableVerticalConstraint { get; }
  
  public ref bool EnableAngularConstraint { get; }
  
  public ref bool EnableLimit { get; }
  
  public ref bool FireEventsOnPath { get; }
  
  public ref float LinearFrequency { get; }
  
  public ref float LinarDampingRatio { get; }
  
  public ref float JointFriction { get; }
  
  public ref Vector PreSolveAnchorPos { get; }
  
}
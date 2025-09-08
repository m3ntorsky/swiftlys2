using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ForceBasedOnDistanceToPlane : IParticleFunctionForce {

  public ref float MinDist { get; }
  
  public ref Vector ForceAtMinDist { get; }
  
  public ref float MaxDist { get; }
  
  public ref Vector ForceAtMaxDist { get; }
  
  public ref Vector PlaneNormal { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref float Exponent { get; }
  
}
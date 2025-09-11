using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_PlanarConstraint : IParticleFunctionConstraint {

  
  public ref Vector PointOnPlane { get; }
  
  public ref Vector PlaneNormal { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref bool GlobalOrigin { get; }
  
  public ref bool GlobalNormal { get; }
  
  public IPerParticleFloatInput RadiusScale { get; }
  
  public IParticleCollectionFloatInput MaximumDistanceToCP { get; }
  
  public ref bool UseOldCode { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetCPOrientationToPointAtCP : IParticleFunctionPreEmission {

  
  public ref int InputCP { get; }
  
  public ref int OutputCP { get; }
  
  public IParticleCollectionFloatInput Interpolation { get; }
  
  public ref bool B2DOrientation { get; }
  
  public ref bool AvoidSingularity { get; }
  
  public ref bool PointAway { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetRandomControlPointPosition : IParticleFunctionPreEmission {

  
  public ref bool UseWorldLocation { get; }
  
  public ref bool Orient { get; }
  
  public ref int CP1 { get; }
  
  public ref int HeadLocation { get; }
  
  public IParticleCollectionFloatInput ReRandomRate { get; }
  
  public ref Vector CPMinPos { get; }
  
  public ref Vector CPMaxPos { get; }
  
  public IParticleCollectionFloatInput Interpolation { get; }
}
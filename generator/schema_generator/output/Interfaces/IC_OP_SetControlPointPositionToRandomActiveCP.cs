using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointPositionToRandomActiveCP : IParticleFunctionPreEmission {

  
  public ref int CP1 { get; }
  
  public ref int HeadLocationMin { get; }
  
  public ref int HeadLocationMax { get; }
  
  public IParticleCollectionFloatInput ResetRate { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointToCenter : IParticleFunctionPreEmission {

  public ref int CP1 { get; }
  
  public ref Vector CP1Pos { get; }
  
  public ref bool UseAvgParticlePos { get; }
  
  public ref ParticleParentSetMode_t SetParent { get; }
  
}
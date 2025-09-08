using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RampCPLinearRandom : IParticleFunctionPreEmission {

  public ref int OutControlPointNumber { get; }
  
  public ref Vector RateMin { get; }
  
  public ref Vector RateMax { get; }
  
}
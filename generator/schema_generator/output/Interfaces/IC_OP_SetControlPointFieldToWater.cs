using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointFieldToWater : IParticleFunctionPreEmission {

  
  public ref int SourceCP { get; }
  
  public ref int DestCP { get; }
  
  public ref int CPField { get; }
}
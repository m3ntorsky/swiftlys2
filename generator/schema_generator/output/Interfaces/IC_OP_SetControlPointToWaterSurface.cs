using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointToWaterSurface : IParticleFunctionPreEmission {

  
  public ref int SourceCP { get; }
  
  public ref int DestCP { get; }
  
  public ref int FlowCP { get; }
  
  public ref int ActiveCP { get; }
  
  public ref int ActiveCPField { get; }
  
  public IParticleCollectionFloatInput RetestRate { get; }
  
  public ref bool AdaptiveThreshold { get; }
}
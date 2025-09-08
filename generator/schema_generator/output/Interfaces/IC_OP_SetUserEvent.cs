using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetUserEvent : IParticleFunctionOperator {

  public IPerParticleFloatInput Input { get; }
  
  public IPerParticleFloatInput RisingEdge { get; }
  
  public ref EventTypeSelection_t RisingEventType { get; }
  
  public IPerParticleFloatInput FallingEdge { get; }
  
  public ref EventTypeSelection_t FallingEventType { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_MovementMoveAlongSkinnedCPSnapshot : IParticleFunctionOperator {

  public ref int ControlPointNumber { get; }
  
  public ref int SnapshotControlPointNumber { get; }
  
  public ref bool SetNormal { get; }
  
  public ref bool SetRadius { get; }
  
  public IPerParticleFloatInput Interpolation { get; }
  
  public IPerParticleFloatInput TValue { get; }
  
}
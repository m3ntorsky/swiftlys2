using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_PositionWarpScalar : IParticleFunctionInitializer {

  public ref Vector WarpMin { get; }
  
  public ref Vector WarpMax { get; }
  
  public IPerParticleFloatInput InputValue { get; }
  
  public ref float PrevPosScale { get; }
  
  public ref int ScaleControlPointNumber { get; }
  
  public ref int ControlPointNumber { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_PositionWarp : IParticleFunctionInitializer {

  public IParticleCollectionVecInput WarpMin { get; }
  
  public IParticleCollectionVecInput WarpMax { get; }
  
  public ref int ScaleControlPointNumber { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref int RadiusComponent { get; }
  
  public ref float WarpTime { get; }
  
  public ref float WarpStartTime { get; }
  
  public ref float PrevPosScale { get; }
  
  public ref bool InvertWarp { get; }
  
  public ref bool UseCount { get; }
  
}
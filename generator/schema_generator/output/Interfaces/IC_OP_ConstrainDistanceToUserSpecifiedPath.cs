using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ConstrainDistanceToUserSpecifiedPath : IParticleFunctionConstraint {

  
  public ref float MinDistance { get; }
  
  public ref float MaxDistance { get; }
  
  public ref float TimeScale { get; }
  
  public ref bool LoopedPath { get; }
  
// CUtlVector< PointDefinitionWithTimeValues_t >
  public ref CUtlVector PointList { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_LockToPointList : IParticleFunctionOperator {

  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
// CUtlVector< PointDefinition_t >
  public ref CUtlVector PointList { get; }
  
  public ref bool PlaceAlongPath { get; }
  
  public ref bool ClosedLoop { get; }
  
  public ref int NumPointsAlongPath { get; }
}
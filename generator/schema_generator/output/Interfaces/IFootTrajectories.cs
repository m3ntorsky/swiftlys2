using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootTrajectories : ISchemaClass {

  
// CUtlVector< CFootTrajectory >
  public ref CUtlVector Trajectories { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootTrajectories : ISchemaClass {

  public ref CUtlVector Trajectories { get; }
  
}
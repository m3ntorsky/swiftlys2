using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootStride : ISchemaClass {

  public IFootCycleDefinition Definition { get; }
  
  public IFootTrajectories Trajectories { get; }
  
}
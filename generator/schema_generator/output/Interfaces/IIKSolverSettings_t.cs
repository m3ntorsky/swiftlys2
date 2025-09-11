using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IIKSolverSettings_t : ISchemaClass {

  
  public ref IKSolverType SolverType { get; }
  
  public ref int NumIterations { get; }
  
  public ref EIKEndEffectorRotationFixUpMode EndEffectorRotationFixUpMode { get; }
}
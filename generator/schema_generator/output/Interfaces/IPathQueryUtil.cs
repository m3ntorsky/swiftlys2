using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPathQueryUtil : ISchemaClass {

  public ref CTransform PathToEntityTransform { get; }
  
  public ref CUtlVector<Vector> PathSamplePositions { get; }
  
  public ref CUtlVector<float> PathSampleParameters { get; }
  
  public ref CUtlVector<float> PathSampleDistances { get; }
  
  public ref bool IsClosedLoop { get; }
  
}
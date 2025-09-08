using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmRootMotionData : ISchemaClass {

  public ref CUtlVector<CTransform> Transforms { get; }
  
  public ref int NumFrames { get; }
  
  public ref float AverageLinearVelocity { get; }
  
  public ref float AverageAngularVelocityRadians { get; }
  
  public ref CTransform TotalDelta { get; }
  
}
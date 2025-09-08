using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICachedPose : ISchemaClass {

  public ref CUtlVector<CTransform> Transforms { get; }
  
  public ref CUtlVector<float> MorphWeights { get; }
  
  public IHSequence Sequence { get; }
  
  public ref float Cycle { get; }
  
}
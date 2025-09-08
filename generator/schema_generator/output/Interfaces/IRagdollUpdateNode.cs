using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRagdollUpdateNode : IUnaryUpdateNode {

  public ref int WeightListIndex { get; }
  
  public ref RagdollPoseControl PoseControlMethod { get; }
  
}
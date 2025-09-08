using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkeletonAnimCapture_t__Frame_t : ISchemaClass {

  public ref float Time { get; }
  
  public ISkeletonAnimCapture_t::FrameStamp_t Stamp { get; }
  
  public ref CTransform Transform { get; }
  
  public ref bool Teleport { get; }
  
  public ref CUtlVector<CTransform> CompositeBones { get; }
  
  public ref CUtlVector<CTransform> SimStateBones { get; }
  
  public ref CUtlVector<CTransform> FeModelAnims { get; }
  
  public ref CUtlVector<VectorAligned> FeModelPos { get; }
  
  public ref CUtlVector<float> FlexControllerWeights { get; }
  
}
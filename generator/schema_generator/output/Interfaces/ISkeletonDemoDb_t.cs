using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkeletonDemoDb_t : ISchemaClass {

  
  public ref CUtlVector<PointerTo<SkeletonAnimCapture_t>> AnimCaptures { get; }
  
// CUtlVector< SkeletonAnimCapture_t::Camera_t >
  public ref CUtlVector CameraTrack { get; }
  
  public ref float RecordingTime { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIKRig : ISchemaClass {

  
  public ref CStrongHandle<InfoForResourceTypeCNmSkeleton> Skeleton { get; }
  
// CUtlVector< CNmIKBody >
  public ref CUtlVector Bodies { get; }
  
// CUtlVector< CNmIKJoint >
  public ref CUtlVector Joints { get; }
}
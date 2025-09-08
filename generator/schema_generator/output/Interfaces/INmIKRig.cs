using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmIKRig : ISchemaClass {

  public CStrongHandle<IInfoForResourceTypeCNmSkeleton> Skeleton { get; }
  
  public ref CUtlVector Bodies { get; }
  
  public ref CUtlVector Joints { get; }
  
}
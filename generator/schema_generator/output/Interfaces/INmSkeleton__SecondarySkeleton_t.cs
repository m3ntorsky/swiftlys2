using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSkeleton__SecondarySkeleton_t : ISchemaClass {

  public ref CGlobalSymbol AttachToBoneID { get; }
  
  public CStrongHandle<IInfoForResourceTypeCNmSkeleton> Skeleton { get; }
  
}
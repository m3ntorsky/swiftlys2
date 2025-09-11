using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkeletonAnimCapture_t__Camera_t : ISchemaClass {

  
  public ref CTransform TmCamera { get; }
  
  public ref float Time { get; }
}
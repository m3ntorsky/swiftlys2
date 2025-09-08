using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRnShapeDesc_t : ISchemaClass {

  public ref uint CollisionAttributeIndex { get; }
  
  public ref uint SurfacePropertyIndex { get; }
  
  public ref CUtlString UserFriendlyName { get; }
  
  public ref bool UserFriendlyNameSealed { get; }
  
  public ref bool UserFriendlyNameLong { get; }
  
  public ref uint ToolMaterialHash { get; }
  
}
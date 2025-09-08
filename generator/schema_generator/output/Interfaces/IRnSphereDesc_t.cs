using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRnSphereDesc_t : IRnShapeDesc_t {

  public ISchemaUntypedField Sphere { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVPhysXSurfacePropertiesList : ISchemaClass {

  
  public ref CUtlVector<PointerTo<CPhysSurfaceProperties>> SurfacePropertiesList { get; }
}
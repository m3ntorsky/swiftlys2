using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IManifestTestResource_t : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public CStrongHandle<IInfoForResourceTypeManifestTestResource_t> Child { get; }
  
}
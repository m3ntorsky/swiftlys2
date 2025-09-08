using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IManifestTestResource_t : ISchemaClass {

  public ref CUtlString Name { get; }
  
  public ref CStrongHandle<InfoForResourceTypeManifestTestResource_t> Child { get; }
  
}
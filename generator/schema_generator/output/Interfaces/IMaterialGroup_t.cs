using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMaterialGroup_t : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref CUtlVector<CStrongHandle<InfoForResourceTypeIMaterial2>> Materials { get; }
}
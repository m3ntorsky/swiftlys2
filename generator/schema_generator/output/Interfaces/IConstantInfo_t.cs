using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IConstantInfo_t : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref CUtlStringToken NameToken { get; }
  
  public ref float Value { get; }
}
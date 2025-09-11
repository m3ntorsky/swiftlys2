using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeEffectDesc_t : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref uint NameHash { get; }
  
  public ref int Type { get; }
  
  public ISchemaUntypedField Params { get; }
}
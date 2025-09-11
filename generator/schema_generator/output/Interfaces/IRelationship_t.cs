using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRelationship_t : ISchemaClass {

  
  public ref Disposition_t Disposition { get; }
  
  public ref int Priority { get; }
}
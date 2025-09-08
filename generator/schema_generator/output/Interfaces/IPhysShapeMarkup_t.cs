using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysShapeMarkup_t : ISchemaClass {

  public ref int BodyInAggregate { get; }
  
  public ref int ShapeInBody { get; }
  
  public ref CGlobalSymbol HitGroup { get; }
  
}
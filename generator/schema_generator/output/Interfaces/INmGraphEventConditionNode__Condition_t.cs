using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmGraphEventConditionNode__Condition_t : ISchemaClass {

  public ref CGlobalSymbol EventID { get; }
  
  public ref NmGraphEventTypeCondition_t EventTypeCondition { get; }
  
}
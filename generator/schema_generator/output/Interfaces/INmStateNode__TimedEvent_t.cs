using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmStateNode__TimedEvent_t : ISchemaClass {

  public ref CGlobalSymbol ID { get; }
  
  public ref float TimeValueSeconds { get; }
  
  public ref CNmStateNode::TimedEvent_t::Comparison_t ComparisionOperator { get; }
  
}
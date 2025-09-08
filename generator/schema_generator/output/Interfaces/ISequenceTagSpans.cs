using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISequenceTagSpans : ISchemaClass {

  public ref CGlobalSymbol SequenceName { get; }
  
  public ref CUtlVector Tags { get; }
  
}
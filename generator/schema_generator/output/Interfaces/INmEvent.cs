using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmEvent : ISchemaClass {

  
  public ref float StartTimeSeconds { get; }
  
  public ref float DurationSeconds { get; }
  
  public ref CGlobalSymbol SyncID { get; }
  
  public ref bool ClientOnly { get; }
}
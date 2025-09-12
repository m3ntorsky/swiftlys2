using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmSyncTrack : ISchemaClass {

  
  public ISchemaUntypedField SyncEvents { get; }
  
  public ref int StartEventOffset { get; }
}
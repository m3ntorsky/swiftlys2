using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISSDSMsg_EndFrame : ISchemaClass {

  public ref CUtlVector Views { get; }
  
}
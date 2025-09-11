using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISSDSMsg_EndFrame : ISchemaClass {

  
// CUtlVector< CSSDSEndFrameViewInfo >
  public ref CUtlVector Views { get; }
}
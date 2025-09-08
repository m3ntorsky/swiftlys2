using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_PlaySequence__CursorState_t : ISchemaClass {

  public ref CHandle<CBaseAnimGraph> Target { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_ScriptedSequence__CursorState_t : ISchemaClass {

  
  public ref CHandle<CBaseEntity> ScriptedSequence { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_PlaySceneBase__CursorState_t : ISchemaClass {

  public ref CHandle<CBaseEntity> SceneInstance { get; }
  
  public ref CHandle<CBaseEntity> MainActor { get; }
  
}
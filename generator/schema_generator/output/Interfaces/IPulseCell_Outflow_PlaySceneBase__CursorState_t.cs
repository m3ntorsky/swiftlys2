using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_PlaySceneBase__CursorState_t : ISchemaClass {

  public CHandle<IBaseEntity> SceneInstance { get; }
  
  public CHandle<IBaseEntity> MainActor { get; }
  
}
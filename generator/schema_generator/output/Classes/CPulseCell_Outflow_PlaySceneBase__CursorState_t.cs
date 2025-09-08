using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_PlaySceneBase__CursorState_t : SchemaClass, IPulseCell_Outflow_PlaySceneBase__CursorState_t {

  public CPulseCell_Outflow_PlaySceneBase__CursorState_t(nint handle) : base(handle) {
  }

  public CHandle<IBaseEntity> SceneInstance {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x16AE3F0C967C210));
  }
  public CHandle<IBaseEntity> MainActor {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x16AE3F0CCB20D99));
  }


}
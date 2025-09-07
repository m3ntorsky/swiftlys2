using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_PlaySceneBase__CursorState_t : SchemaClass, IPulseCell_Outflow_PlaySceneBase__CursorState_t {

  public CPulseCell_Outflow_PlaySceneBase__CursorState_t(nint handle) : base(handle) {
  }

  public CPulseCell_Outflow_PlaySceneBase__CursorState_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CBaseEntity > SceneInstance {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x16AE3F0C967C210));
  }
  public ref CHandle< CBaseEntity > MainActor {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x16AE3F0CCB20D99));
  }


}
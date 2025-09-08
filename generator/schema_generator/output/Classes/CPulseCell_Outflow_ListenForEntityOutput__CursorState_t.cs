using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_ListenForEntityOutput__CursorState_t : SchemaClass, IPulseCell_Outflow_ListenForEntityOutput__CursorState_t {

  public CPulseCell_Outflow_ListenForEntityOutput__CursorState_t(nint handle) : base(handle) {
  }

  public ref CHandle<CBaseEntity> Entity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xC31517AD2F3BEB7A));
  }


}
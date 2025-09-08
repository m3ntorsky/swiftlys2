using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_ScriptedSequence__CursorState_t : SchemaClass, IPulseCell_Outflow_ScriptedSequence__CursorState_t {

  public CPulseCell_Outflow_ScriptedSequence__CursorState_t(nint handle) : base(handle) {
  }

  public ref CHandle<CBaseEntity> ScriptedSequence {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xA508823E4DD9D67A));
  }


}
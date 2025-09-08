using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_PlaySequence__CursorState_t : SchemaClass, IPulseCell_PlaySequence__CursorState_t {

  public CPulseCell_PlaySequence__CursorState_t(nint handle) : base(handle) {
  }

  public CHandle<IBaseAnimGraph> Target {
    get => new CHandle<CBaseAnimGraph>(_Handle + Schema.GetOffset(0x2C22B771CE35901A));
  }


}
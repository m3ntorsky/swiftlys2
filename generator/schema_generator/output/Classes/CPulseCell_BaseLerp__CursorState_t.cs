using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_BaseLerp__CursorState_t : SchemaClass, IPulseCell_BaseLerp__CursorState_t {

  public CPulseCell_BaseLerp__CursorState_t(nint handle) : base(handle) {
  }

  public CPulseCell_BaseLerp__CursorState_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameTime_t StartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1FAAE76897B5FA8E));
  }
  public IGameTime_t EndTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1FAAE7687AA8F56B));
  }


}
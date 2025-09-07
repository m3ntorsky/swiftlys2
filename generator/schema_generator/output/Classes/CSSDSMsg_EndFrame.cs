using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSSDSMsg_EndFrame : SchemaClass, ISSDSMsg_EndFrame {

  public CSSDSMsg_EndFrame(nint handle) : base(handle) {
  }

  public CSSDSMsg_EndFrame(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CSSDSEndFrameViewInfo > Views {
    get => ref _Handle.AsRef<CUtlVector< CSSDSEndFrameViewInfo >>(Schema.GetOffset(0x6F265E19E9FEAC51));
  }


}
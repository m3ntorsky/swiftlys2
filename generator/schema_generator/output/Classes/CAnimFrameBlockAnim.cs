using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimFrameBlockAnim : SchemaClass, IAnimFrameBlockAnim {

  public CAnimFrameBlockAnim(nint handle) : base(handle) {
  }

  public ref int StartFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6318445C9134F088));
  }
  public ref int EndFrame {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6318445CEA91BD07));
  }
  public ref CUtlVector<int> SegmentIndexArray {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0x6318445C1A46EA6B));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimEncodedFrames : SchemaClass, IAnimEncodedFrames {

  public CAnimEncodedFrames(nint handle) : base(handle) {
  }

  public ref CBufferString FileName {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x63992F5DC8D68508));
  }
  public ref int Frames {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x63992F5DD2101EE3));
  }
  public ref int FramesPerBlock {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x63992F5DFFC5A547));
  }
  public ref CUtlVector FrameblockArray {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x63992F5D2805E598));
  }
  public IAnimEncodeDifference UsageDifferences {
    get => new CAnimEncodeDifference(_Handle + Schema.GetOffset(0x63992F5D27B13638));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimData : SchemaClass, IAnimData {

  public CAnimData(nint handle) : base(handle) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0xA4868F934D8F5786));
  }
  public ref CUtlVector AnimArray {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA4868F939FE8AF0D));
  }
  public ref CUtlVector DecoderArray {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA4868F93AB12D6C4));
  }
  public ref int MaxUniqueFrameIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA4868F938FB0EA0D));
  }
  public ref CUtlVector SegmentArray {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA4868F933714FD2F));
  }


}
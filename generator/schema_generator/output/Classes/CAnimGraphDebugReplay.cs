using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimGraphDebugReplay : SchemaClass, IAnimGraphDebugReplay {

  public CAnimGraphDebugReplay(nint handle) : base(handle) {
  }

  public ref CUtlString AnimGraphFileName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x31D5349314D2CC69));
  }
  public ref CUtlVector FrameList {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x31D5349393EB99F2));
  }
  public ref int StartIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x31D534939F316D25));
  }
  public ref int WriteIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x31D53493161871B8));
  }
  public ref int FrameCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x31D53493B0C97215));
  }


}
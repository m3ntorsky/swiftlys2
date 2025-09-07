using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class TagSpan_t : SchemaClass, ITagSpan_t {

  public TagSpan_t(nint handle) : base(handle) {
  }

  public TagSpan_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int TagIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA2611404D66997C9));
  }
  public ref float StartCycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA26114043A764D4F));
  }
  public ref float EndCycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA26114040B523694));
  }


}
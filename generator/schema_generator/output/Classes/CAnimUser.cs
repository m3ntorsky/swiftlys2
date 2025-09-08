using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimUser : SchemaClass, IAnimUser {

  public CAnimUser(nint handle) : base(handle) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0xA77D4C084D8F5786));
  }
  public ref int Type {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA77D4C0818853D59));
  }


}
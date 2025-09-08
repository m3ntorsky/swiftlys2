using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MotionDBIndex : SchemaClass, IMotionDBIndex {

  public MotionDBIndex(nint handle) : base(handle) {
  }

  public ref uint Index {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x35C035B7B73DBE67));
  }


}
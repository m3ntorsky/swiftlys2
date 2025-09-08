using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AnimNodeID : SchemaClass, IAnimNodeID {

  public AnimNodeID(nint handle) : base(handle) {
  }

  public ref uint Id {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x9E71ACD1B4B6E980));
  }


}
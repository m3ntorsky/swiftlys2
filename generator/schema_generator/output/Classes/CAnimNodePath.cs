using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimNodePath : SchemaClass, IAnimNodePath {

  public CAnimNodePath(nint handle) : base(handle) {
  }

  public IAnimNodeID Path {
    get => new AnimNodeID(_Handle, 0xE070E30C2915C8D6, 11, 4, 4);
  }
  public ref int Count {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE070E30C7D31AC08));
  }


}
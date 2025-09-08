using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnNode_t : SchemaClass, IRnNode_t {

  public RnNode_t(nint handle) : base(handle) {
  }

  public ref Vector Min {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x7C7D54E2F4B0AA63));
  }
  public ref uint Children {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x7C7D54E2D0F4635E));
  }
  public ref Vector Max {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x7C7D54E2EAC4225D));
  }
  public ref uint TriangleOffset {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x7C7D54E2AFE22CE6));
  }


}
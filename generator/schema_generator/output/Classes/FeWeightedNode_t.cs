using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeWeightedNode_t : SchemaClass, IFeWeightedNode_t {

  public FeWeightedNode_t(nint handle) : base(handle) {
  }

  public ref ushort Node {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x7CA6E056CD6694B9));
  }
  public ref ushort Weight {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x7CA6E0564C8D62A5));
  }


}
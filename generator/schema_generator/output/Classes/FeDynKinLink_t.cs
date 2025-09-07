using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeDynKinLink_t : SchemaClass, IFeDynKinLink_t {

  public FeDynKinLink_t(nint handle) : base(handle) {
  }

  public FeDynKinLink_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort Parent {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xA0FBF6C40AABB9D1));
  }
  public ref ushort Child {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xA0FBF6C4FE653481));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VPhysXConstraint2_t : SchemaClass, IVPhysXConstraint2_t {

  public VPhysXConstraint2_t(nint handle) : base(handle) {
  }

  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x6FB758FDCE6E9C28));
  }
  public ref ushort Parent {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x6FB758FD0AABB9D1));
  }
  public ref ushort Child {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x6FB758FDFE653481));
  }
  public IVPhysXConstraintParams_t Params {
    get => new VPhysXConstraintParams_t(_Handle + Schema.GetOffset(0x6FB758FD640EA8F3));
  }


}
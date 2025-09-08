using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeRigidColliderIndices_t : SchemaClass, IFeRigidColliderIndices_t {

  public FeRigidColliderIndices_t(nint handle) : base(handle) {
  }

  public ref ushort TaperedCapsuleRigidIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x3411B17B4168EBCE));
  }
  public ref ushort SphereRigidIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x3411B17B3AA961B5));
  }
  public ref ushort BoxRigidIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x3411B17B46589173));
  }
  public ref ushort SDFRigidIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x3411B17BCE5B5E19));
  }
  public ref ushort CollisionPlaneIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x3411B17B7638A2B9));
  }


}
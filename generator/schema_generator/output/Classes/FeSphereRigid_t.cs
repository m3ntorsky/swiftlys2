using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSphereRigid_t : SchemaClass, IFeSphereRigid_t {

  public FeSphereRigid_t(nint handle) : base(handle) {
  }

  public FeSphereRigid_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref fltx4 Sphere {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xA76DA0A39E2AC48C));
  }
  public ref ushort Node {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xA76DA0A3CD6694B9));
  }
  public ref ushort CollisionMask {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xA76DA0A30ED3454F));
  }
  public ref ushort VertexMapIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xA76DA0A37B332E39));
  }
  public ref ushort Flags {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xA76DA0A3B8D52E48));
  }


}
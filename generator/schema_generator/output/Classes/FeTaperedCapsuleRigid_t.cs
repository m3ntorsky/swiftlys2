using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeTaperedCapsuleRigid_t : SchemaClass, IFeTaperedCapsuleRigid_t {

  public FeTaperedCapsuleRigid_t(nint handle) : base(handle) {
  }

  public FeTaperedCapsuleRigid_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<fltx4> Sphere {
    get => new SchemaFixedArray<fltx4>(_Handle + Schema.GetOffset(0x4B2017EE9E2AC48C));
  }
  public ref ushort Node {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x4B2017EECD6694B9));
  }
  public ref ushort CollisionMask {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x4B2017EE0ED3454F));
  }
  public ref ushort VertexMapIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x4B2017EE7B332E39));
  }
  public ref ushort Flags {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x4B2017EEB8D52E48));
  }


}
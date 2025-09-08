using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeBoxRigid_t : SchemaClass, IFeBoxRigid_t {

  public FeBoxRigid_t(nint handle) : base(handle) {
  }

  public ref CTransform TmFrame2 {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x63C7789F568CD94B));
  }
  public ref ushort Node {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x63C7789FCD6694B9));
  }
  public ref ushort CollisionMask {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x63C7789F0ED3454F));
  }
  public ref Vector Size {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x63C7789FCB89C418));
  }
  public ref ushort VertexMapIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x63C7789F7B332E39));
  }
  public ref ushort Flags {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x63C7789FB8D52E48));
  }


}
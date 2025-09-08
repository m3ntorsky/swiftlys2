using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VPhysXBodyPart_t : SchemaClass, IVPhysXBodyPart_t {

  public VPhysXBodyPart_t(nint handle) : base(handle) {
  }

  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x53DE59CDCE6E9C28));
  }
  public ref float Mass {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x53DE59CDCD83D263));
  }
  public IVPhysics2ShapeDef_t RnShape {
    get => new VPhysics2ShapeDef_t(_Handle + Schema.GetOffset(0x53DE59CDD69E7012));
  }
  public ref ushort CollisionAttributeIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x53DE59CDC7B64DF7));
  }
  public ref ushort Reserved {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x53DE59CD94BD4B01));
  }
  public ref float InertiaScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x53DE59CD4E6CAB2F));
  }
  public ref float LinearDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x53DE59CD4E6B7F64));
  }
  public ref float AngularDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x53DE59CD0E32E897));
  }
  public ref float LinearDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x53DE59CDB3D686BC));
  }
  public ref float AngularDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x53DE59CDDCE9A7D1));
  }
  public ref bool OverrideMassCenter {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x53DE59CD19E47DF8));
  }
  public ref Vector MassCenterOverride {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x53DE59CD7249FAE4));
  }


}
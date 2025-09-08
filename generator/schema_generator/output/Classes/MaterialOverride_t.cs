using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MaterialOverride_t : BaseSceneObjectOverride_t, IMaterialOverride_t {

  public MaterialOverride_t(nint handle) : base(handle) {
  }

  public ref uint SubSceneObject {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xFB7BFECB55C3CCBC));
  }
  public ref uint DrawCallIndex {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xFB7BFECBFA5614D5));
  }
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> Material {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIMaterial2>>(Schema.GetOffset(0xFB7BFECB972B1076));
  }
  public ref Vector LinearTintColor {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xFB7BFECB6901D28C));
  }


}
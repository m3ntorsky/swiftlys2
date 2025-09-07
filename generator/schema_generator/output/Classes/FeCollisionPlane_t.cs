using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeCollisionPlane_t : SchemaClass, IFeCollisionPlane_t {

  public FeCollisionPlane_t(nint handle) : base(handle) {
  }

  public FeCollisionPlane_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort CtrlParent {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xF8EBA99555049230));
  }
  public ref ushort ChildNode {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xF8EBA99592A8E0E9));
  }
  public IRnPlane_t Plane {
    get => new RnPlane_t(_Handle + Schema.GetOffset(0xF8EBA995671CB5D5));
  }
  public ref float Strength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF8EBA995AFA3323A));
  }


}
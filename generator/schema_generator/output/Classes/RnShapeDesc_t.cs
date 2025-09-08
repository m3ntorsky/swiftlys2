using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnShapeDesc_t : SchemaClass, IRnShapeDesc_t {

  public RnShapeDesc_t(nint handle) : base(handle) {
  }

  public ref uint CollisionAttributeIndex {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xA24D7D10C7B64DF7));
  }
  public ref uint SurfacePropertyIndex {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xA24D7D106DED6187));
  }
  public ref CUtlString UserFriendlyName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xA24D7D1000D4523E));
  }
  public ref bool UserFriendlyNameSealed {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA24D7D1076DBAE3A));
  }
  public ref bool UserFriendlyNameLong {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA24D7D10F02591B8));
  }
  public ref uint ToolMaterialHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xA24D7D105C3E2DDE));
  }


}
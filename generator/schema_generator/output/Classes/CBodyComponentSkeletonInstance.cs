using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBodyComponentSkeletonInstance : CBodyComponent, IBodyComponentSkeletonInstance {

  public CBodyComponentSkeletonInstance(nint handle) : base(handle) {
  }

  public CBodyComponentSkeletonInstance(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISkeletonInstance SkeletonInstance {
    get => new CSkeletonInstance(_Handle + Schema.GetOffset(0x4581C459228537B9));
  }

  public void SkeletonInstanceUpdated() {
    Schema.Update(_Handle, 0x4581C459228537B9);
  }
}
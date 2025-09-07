using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRagdollMagnet : CPointEntity, IRagdollMagnet {

  public CRagdollMagnet(nint handle) : base(handle) {
  }

  public CRagdollMagnet(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7C6BA43F3A7C5965));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7C6BA43FA921CA53));
  }
  public ref float Force {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7C6BA43FB9B6AFA4));
  }
  public ref Vector Axis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x7C6BA43F2B06DE94));
  }


}
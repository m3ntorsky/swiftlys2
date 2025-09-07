using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRagdollConstraint : CPhysConstraint, IRagdollConstraint {

  public CRagdollConstraint(nint handle) : base(handle) {
  }

  public CRagdollConstraint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Xmin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF36946DA76E67DC1));
  }
  public ref float Xmax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF36946DA68F9EF6F));
  }
  public ref float Ymin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF36946DACE2F1828));
  }
  public ref float Ymax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF36946DAC4429022));
  }
  public ref float Zmin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF36946DAC34E881F));
  }
  public ref float Zmax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF36946DAD13B1671));
  }
  public ref float Xfriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF36946DA08758E19));
  }
  public ref float Yfriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF36946DAEFC8C6C6));
  }
  public ref float Zfriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF36946DA5587BDC3));
  }


}
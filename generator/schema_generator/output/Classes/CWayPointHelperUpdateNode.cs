using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWayPointHelperUpdateNode : CUnaryUpdateNode, IWayPointHelperUpdateNode {

  public CWayPointHelperUpdateNode(nint handle) : base(handle) {
  }

  public CWayPointHelperUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float StartCycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x109BD628ABB46051));
  }
  public ref float EndCycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x109BD628176E8F62));
  }
  public ref bool OnlyGoals {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x109BD6283526BA11));
  }
  public ref bool PreventOvershoot {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x109BD628B161EADA));
  }
  public ref bool PreventUndershoot {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x109BD628C22276F8));
  }


}
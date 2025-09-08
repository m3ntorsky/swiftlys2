using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeCtrlSoftOffset_t : SchemaClass, IFeCtrlSoftOffset_t {

  public FeCtrlSoftOffset_t(nint handle) : base(handle) {
  }

  public ref ushort CtrlParent {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xCA94FF2955049230));
  }
  public ref ushort CtrlChild {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xCA94FF295BE48066));
  }
  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xCA94FF29B2913856));
  }
  public ref float Alpha {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCA94FF29684C8871));
  }


}
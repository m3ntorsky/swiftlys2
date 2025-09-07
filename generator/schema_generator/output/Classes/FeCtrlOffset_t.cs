using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeCtrlOffset_t : SchemaClass, IFeCtrlOffset_t {

  public FeCtrlOffset_t(nint handle) : base(handle) {
  }

  public FeCtrlOffset_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x83912B89B2913856));
  }
  public ref ushort CtrlParent {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x83912B8955049230));
  }
  public ref ushort CtrlChild {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x83912B895BE48066));
  }


}
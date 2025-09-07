using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeCtrlOsOffset_t : SchemaClass, IFeCtrlOsOffset_t {

  public FeCtrlOsOffset_t(nint handle) : base(handle) {
  }

  public FeCtrlOsOffset_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort CtrlParent {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xA9B7D3DF55049230));
  }
  public ref ushort CtrlChild {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xA9B7D3DF5BE48066));
  }


}
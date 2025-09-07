using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeSoftParent_t : SchemaClass, IFeSoftParent_t {

  public FeSoftParent_t(nint handle) : base(handle) {
  }

  public FeSoftParent_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Parent {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2404393716640171));
  }
  public ref float Alpha {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x24043937684C8871));
  }


}
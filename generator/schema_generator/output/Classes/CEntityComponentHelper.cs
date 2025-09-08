using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEntityComponentHelper : SchemaClass, IEntityComponentHelper {

  public CEntityComponentHelper(nint handle) : base(handle) {
  }

  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x714DB384DC74A14C));
  }
  public IEntComponentInfo_t Info {
    get => new EntComponentInfo_t(_Handle + Schema.GetOffset(0x714DB3840F0BFD1B));
  }
  public ref int Priority {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x714DB384E7EFB335));
  }
  public IEntityComponentHelper Next {
    get => new CEntityComponentHelper(_Handle + Schema.GetOffset(0x714DB38432B11E0E));
  }


}
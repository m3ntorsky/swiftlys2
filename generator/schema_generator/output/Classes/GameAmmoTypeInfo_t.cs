using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class GameAmmoTypeInfo_t : AmmoTypeInfo_t, IGameAmmoTypeInfo_t {

  public GameAmmoTypeInfo_t(nint handle) : base(handle) {
  }

  public ref int BuySize {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x64034C7E8E17434E));
  }
  public ref int Cost {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x64034C7E919660C4));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CItemDogtags : CItem, IItemDogtags {

  public CItemDogtags(nint handle) : base(handle) {
  }

  public CItemDogtags(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CCSPlayerPawn > OwningPlayer {
    get => ref _Handle.AsRef<CHandle< CCSPlayerPawn >>(Schema.GetOffset(0x69879A78258F5D24));
  }
  public ref CHandle< CCSPlayerPawn > KillingPlayer {
    get => ref _Handle.AsRef<CHandle< CCSPlayerPawn >>(Schema.GetOffset(0x69879A784617E6C6));
  }

  public void OwningPlayerUpdated() {
    Schema.Update(_Handle, 0x69879A78258F5D24);
  }
  public void KillingPlayerUpdated() {
    Schema.Update(_Handle, 0x69879A784617E6C6);
  }
}
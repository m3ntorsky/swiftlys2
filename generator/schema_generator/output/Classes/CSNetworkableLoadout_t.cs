using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSNetworkableLoadout_t : SchemaClass, ISNetworkableLoadout_t {

  public CSNetworkableLoadout_t(nint handle) : base(handle) {
  }

  public CSNetworkableLoadout_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEconItemView Item {
    get => new CEconItemView(_Handle + Schema.GetOffset(0xCE5E84FADCE71866));
  }
  public ref ushort Team {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xCE5E84FA7922011B));
  }
  public ref ushort Slot {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xCE5E84FAA99E43BE));
  }

  public void ItemUpdated() {
    Schema.Update(_Handle, 0xCE5E84FADCE71866);
  }
  public void TeamUpdated() {
    Schema.Update(_Handle, 0xCE5E84FA7922011B);
  }
  public void SlotUpdated() {
    Schema.Update(_Handle, 0xCE5E84FAA99E43BE);
  }
}
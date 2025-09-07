using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CItemDefuser : CItem, IItemDefuser {

  public CItemDefuser(nint handle) : base(handle) {
  }

  public CItemDefuser(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntitySpottedState_t EntitySpottedState {
    get => new EntitySpottedState_t(_Handle + Schema.GetOffset(0xC9362933032B547C));
  }
  public ref int SpotRules {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC9362933776CCE44));
  }


}
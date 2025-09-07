using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CToggleComponentActionUpdater : CAnimActionUpdater, IToggleComponentActionUpdater {

  public CToggleComponentActionUpdater(nint handle) : base(handle) {
  }

  public CToggleComponentActionUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAnimComponentID ComponentID {
    get => new AnimComponentID(_Handle + Schema.GetOffset(0x4641AA28C1B9267D));
  }
  public ref bool SetEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4641AA28BC6294B8));
  }


}
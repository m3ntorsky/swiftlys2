using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerRemove : CBaseTrigger, ITriggerRemove {

  public CTriggerRemove(nint handle) : base(handle) {
  }

  public CTriggerRemove(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OnRemove {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x97A9D4D67DC268F8));
  }


}
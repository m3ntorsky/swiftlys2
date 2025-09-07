using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerMultiple : CBaseTrigger, ITriggerMultiple {

  public CTriggerMultiple(nint handle) : base(handle) {
  }

  public CTriggerMultiple(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OnTrigger {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x327F607E81E0BFEC));
  }


}
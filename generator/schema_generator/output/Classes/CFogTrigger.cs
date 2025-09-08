using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFogTrigger : CBaseTrigger, IFogTrigger {

  public CFogTrigger(nint handle) : base(handle) {
  }

  public Ifogparams_t Fog {
    get => new fogparams_t(_Handle + Schema.GetOffset(0x18A9AE6A9014635F));
  }


}
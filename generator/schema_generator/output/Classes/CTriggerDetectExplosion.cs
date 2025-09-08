using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerDetectExplosion : CBaseTrigger, ITriggerDetectExplosion {

  public CTriggerDetectExplosion(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnDetectedExplosion {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xEDC17DD03CDD7F71));
  }


}
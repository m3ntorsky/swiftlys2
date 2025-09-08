using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvWindVolume : CBaseEntity, IEnvWindVolume {

  public CEnvWindVolume(nint handle) : base(handle) {
  }



  public void ActiveUpdated() {
    Schema.Update(_Handle, 0xCD7AC5418334208F);
  }
  public void BoxMinsUpdated() {
    Schema.Update(_Handle, 0xCD7AC541D8201373);
  }
  public void BoxMaxsUpdated() {
    Schema.Update(_Handle, 0xCD7AC541817A3B31);
  }
  public void StartDisabledUpdated() {
    Schema.Update(_Handle, 0xCD7AC54161ED0C4F);
  }
  public void ShapeUpdated() {
    Schema.Update(_Handle, 0xCD7AC54121208A02);
  }
  public void WindSpeedMultiplierUpdated() {
    Schema.Update(_Handle, 0xCD7AC541A22A3F81);
  }
  public void WindTurbulenceMultiplierUpdated() {
    Schema.Update(_Handle, 0xCD7AC54120DA30CD);
  }
  public void WindSpeedVariationMultiplierUpdated() {
    Schema.Update(_Handle, 0xCD7AC5416B9AC20C);
  }
  public void WindDirectionVariationMultiplierUpdated() {
    Schema.Update(_Handle, 0xCD7AC5417F3AB3AA);
  }
}
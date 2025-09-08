using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayerVisibility : CBaseEntity, IPlayerVisibility {

  public CPlayerVisibility(nint handle) : base(handle) {
  }



  public void VisibilityStrengthUpdated() {
    Schema.Update(_Handle, 0x695BAF9B9E8E4E);
  }
  public void FogDistanceMultiplierUpdated() {
    Schema.Update(_Handle, 0x695BAFDB1CD031);
  }
  public void FogMaxDensityMultiplierUpdated() {
    Schema.Update(_Handle, 0x695BAF7F993C70);
  }
  public void FadeTimeUpdated() {
    Schema.Update(_Handle, 0x695BAF00BEDB08);
  }
  public void StartDisabledUpdated() {
    Schema.Update(_Handle, 0x695BAF61ED0C4F);
  }
  public void IsEnabledUpdated() {
    Schema.Update(_Handle, 0x695BAF5360D70E);
  }
}
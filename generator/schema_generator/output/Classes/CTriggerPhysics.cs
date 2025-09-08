using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerPhysics : CBaseTrigger, ITriggerPhysics {

  public CTriggerPhysics(nint handle) : base(handle) {
  }



  public void GravityScaleUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D3F22682F1);
  }
  public void LinearLimitUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D38455E743);
  }
  public void LinearDampingUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D395E4E646);
  }
  public void AngularLimitUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D3497B8D18);
  }
  public void AngularDampingUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D36F1B9C61);
  }
  public void LinearForceUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D32DAF4653);
  }
  public void FrequencyUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D3D2C16DD7);
  }
  public void DampingRatioUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D3B40C859E);
  }
  public void LinearForcePointAtUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D3C27DF46E);
  }
  public void CollapseToForcePointUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D3EB895D00);
  }
  public void LinearForcePointAtWorldUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D3C80D3782);
  }
  public void LinearForceDirectionUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D36076B2FC);
  }
  public void ConvertToDebrisWhenPossibleUpdated() {
    Schema.Update(_Handle, 0xD6C7C8D36AD4D155);
  }
}
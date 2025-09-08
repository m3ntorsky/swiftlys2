using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class sky3dparams_t : SchemaClass, Isky3dparams_t {

  public sky3dparams_t(nint handle) : base(handle) {
  }



  public void ScaleUpdated() {
    Schema.Update(_Handle, 0x49687CC482971C71);
  }
  public void OriginUpdated() {
    Schema.Update(_Handle, 0x49687CC4D97F9A4F);
  }
  public void Clip3DSkyBoxNearToWorldFarUpdated() {
    Schema.Update(_Handle, 0x49687CC482943804);
  }
  public void Clip3DSkyBoxNearToWorldFarOffsetUpdated() {
    Schema.Update(_Handle, 0x49687CC49D6E9441);
  }
  public void FogUpdated() {
    Schema.Update(_Handle, 0x49687CC4A1F3723F);
  }
  public void WorldGroupIDUpdated() {
    Schema.Update(_Handle, 0x49687CC49414E3F3);
  }
}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCitadelSoundOpvarSetOBB : CBaseEntity, ICitadelSoundOpvarSetOBB {

  public CCitadelSoundOpvarSetOBB(nint handle) : base(handle) {
  }



  public void StackNameUpdated() {
    Schema.Update(_Handle, 0xD3F8645E3B3E9CD4);
  }
  public void OperatorNameUpdated() {
    Schema.Update(_Handle, 0xD3F8645EF6140996);
  }
  public void OpvarNameUpdated() {
    Schema.Update(_Handle, 0xD3F8645E2CAEFF3C);
  }
  public void DistanceInnerMinsUpdated() {
    Schema.Update(_Handle, 0xD3F8645EC7540883);
  }
  public void DistanceInnerMaxsUpdated() {
    Schema.Update(_Handle, 0xD3F8645E705E7E61);
  }
  public void DistanceOuterMinsUpdated() {
    Schema.Update(_Handle, 0xD3F8645E185EC6F4);
  }
  public void DistanceOuterMaxsUpdated() {
    Schema.Update(_Handle, 0xD3F8645E99738B36);
  }
  public void AABBDirectionUpdated() {
    Schema.Update(_Handle, 0xD3F8645EE8CF552C);
  }
}
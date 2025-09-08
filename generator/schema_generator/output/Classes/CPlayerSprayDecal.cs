using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayerSprayDecal : CModelPointEntity, IPlayerSprayDecal {

  public CPlayerSprayDecal(nint handle) : base(handle) {
  }



  public void UniqueIDUpdated() {
    Schema.Update(_Handle, 0x782380E1C7F9595F);
  }
  public void AccountIDUpdated() {
    Schema.Update(_Handle, 0x782380E15D6DC0F0);
  }
  public void TraceIDUpdated() {
    Schema.Update(_Handle, 0x782380E1D326AF6A);
  }
  public void RtGcTimeUpdated() {
    Schema.Update(_Handle, 0x782380E1F2BA46AC);
  }
  public void EndPosUpdated() {
    Schema.Update(_Handle, 0x782380E18DD24760);
  }
  public void StartUpdated() {
    Schema.Update(_Handle, 0x782380E141EEE6BF);
  }
  public void LeftUpdated() {
    Schema.Update(_Handle, 0x782380E1C965C1D0);
  }
  public void NormalUpdated() {
    Schema.Update(_Handle, 0x782380E1363057B2);
  }
  public void PlayerUpdated() {
    Schema.Update(_Handle, 0x782380E1E30D6DFC);
  }
  public void EntityUpdated() {
    Schema.Update(_Handle, 0x782380E1A2D5FAD6);
  }
  public void HitboxUpdated() {
    Schema.Update(_Handle, 0x782380E16D9A48B3);
  }
  public void CreationTimeUpdated() {
    Schema.Update(_Handle, 0x782380E1525557E7);
  }
  public void TintIDUpdated() {
    Schema.Update(_Handle, 0x782380E12CA2D64D);
  }
  public void VersionUpdated() {
    Schema.Update(_Handle, 0x782380E1B0AB8B1B);
  }
  public void SignatureUpdated() {
    Schema.Update(_Handle, 0x782380E133A8D6DC);
  }
}
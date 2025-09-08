using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayerResource : CBaseEntity, ICSPlayerResource {

  public CCSPlayerResource(nint handle) : base(handle) {
  }

  public ref bool FoundGoalPositions {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBEE9B915A90F0670));
  }

  public void HostageAliveUpdated() {
    Schema.Update(_Handle, 0xBEE9B9154C5B2E7F);
  }
  public void IsHostageFollowingSomeoneUpdated() {
    Schema.Update(_Handle, 0xBEE9B9153F8AA9BB);
  }
  public void HostageEntityIDsUpdated() {
    Schema.Update(_Handle, 0xBEE9B9150EEFA350);
  }
  public void BombsiteCenterAUpdated() {
    Schema.Update(_Handle, 0xBEE9B915A11A73BA);
  }
  public void BombsiteCenterBUpdated() {
    Schema.Update(_Handle, 0xBEE9B915A01A7227);
  }
  public void HostageRescueXUpdated() {
    Schema.Update(_Handle, 0xBEE9B91584FE2109);
  }
  public void HostageRescueYUpdated() {
    Schema.Update(_Handle, 0xBEE9B91583FE1F76);
  }
  public void HostageRescueZUpdated() {
    Schema.Update(_Handle, 0xBEE9B91582FE1DE3);
  }
  public void EndMatchNextMapAllVotedUpdated() {
    Schema.Update(_Handle, 0xBEE9B915E1946791);
  }
}
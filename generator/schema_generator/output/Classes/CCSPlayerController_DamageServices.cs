using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayerController_DamageServices : CPlayerControllerComponent, ICSPlayerController_DamageServices {

  public CCSPlayerController_DamageServices(nint handle) : base(handle) {
  }

  public CCSPlayerController_DamageServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int SendUpdate {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC354634BBB7D4BC2));
  }
  public ref CUtlVectorEmbeddedNetworkVar< CDamageRecord > DamageList {
    get => ref _Handle.AsRef<CUtlVectorEmbeddedNetworkVar< CDamageRecord >>(Schema.GetOffset(0xC354634B48D4B628));
  }

  public void SendUpdateUpdated() {
    Schema.Update(_Handle, 0xC354634BBB7D4BC2);
  }
  public void DamageListUpdated() {
    Schema.Update(_Handle, 0xC354634B48D4B628);
  }
}
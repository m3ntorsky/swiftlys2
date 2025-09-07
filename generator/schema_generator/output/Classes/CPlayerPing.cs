using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayerPing : CBaseEntity, IPlayerPing {

  public CPlayerPing(nint handle) : base(handle) {
  }

  public CPlayerPing(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CCSPlayerPawn > Player {
    get => ref _Handle.AsRef<CHandle< CCSPlayerPawn >>(Schema.GetOffset(0x5943E25F68856C16));
  }
  public ref CHandle< CBaseEntity > PingedEntity {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x5943E25F35D9D429));
  }
  public ref int Type {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5943E25FC932D7CC));
  }
  public ref bool Urgent {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5943E25F4F5EE9D0));
  }
  public ISchemaFixedString PlaceName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x5943E25F6039F660));
  }

  public void PlayerUpdated() {
    Schema.Update(_Handle, 0x5943E25F68856C16);
  }
  public void PingedEntityUpdated() {
    Schema.Update(_Handle, 0x5943E25F35D9D429);
  }
  public void TypeUpdated() {
    Schema.Update(_Handle, 0x5943E25FC932D7CC);
  }
  public void UrgentUpdated() {
    Schema.Update(_Handle, 0x5943E25F4F5EE9D0);
  }
  public void PlaceNameUpdated() {
    Schema.Update(_Handle, 0x5943E25F6039F660);
  }
}
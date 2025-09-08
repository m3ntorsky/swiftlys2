using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayerController_InventoryServices : CPlayerControllerComponent, ICSPlayerController_InventoryServices {

  public CCSPlayerController_InventoryServices(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<uint> EquippedPlayerSprayIDs {
    get => new SchemaFixedArray<uint>(_Handle, 0xC1D00782CE970C93, 1, 4, 4);
  }

  public void MusicIDUpdated() {
    Schema.Update(_Handle, 0xC1D0078289F71A5C);
  }
  public void RankUpdated() {
    Schema.Update(_Handle, 0xC1D007826A7861C7);
  }
  public void PersonaDataPublicLevelUpdated() {
    Schema.Update(_Handle, 0xC1D00782BE2880D0);
  }
  public void PersonaDataPublicCommendsLeaderUpdated() {
    Schema.Update(_Handle, 0xC1D00782671B0B25);
  }
  public void PersonaDataPublicCommendsTeacherUpdated() {
    Schema.Update(_Handle, 0xC1D00782610CA282);
  }
  public void PersonaDataPublicCommendsFriendlyUpdated() {
    Schema.Update(_Handle, 0xC1D00782B3DA495B);
  }
  public void PersonaDataXpTrailLevelUpdated() {
    Schema.Update(_Handle, 0xC1D0078228192B7D);
  }
  public void ServerAuthoritativeWeaponSlotsUpdated() {
    Schema.Update(_Handle, 0xC1D007826EED2FF6);
  }
  public void NetworkableLoadoutUpdated() {
    Schema.Update(_Handle, 0xC1D0078226705D53);
  }
}
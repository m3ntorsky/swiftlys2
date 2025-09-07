using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayerController_InventoryServices : CPlayerControllerComponent, ICSPlayerController_InventoryServices {

  public CCSPlayerController_InventoryServices(nint handle) : base(handle) {
  }

  public CCSPlayerController_InventoryServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort MusicID {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xC1D0078289F71A5C));
  }
  public ref MedalRank_t Rank {
    get => ref _Handle.AsRef<MedalRank_t>(Schema.GetOffset(0xC1D007826A7861C7));
  }
  public ref int PersonaDataPublicLevel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC1D00782BE2880D0));
  }
  public ref int PersonaDataPublicCommendsLeader {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC1D00782671B0B25));
  }
  public ref int PersonaDataPublicCommendsTeacher {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC1D00782610CA282));
  }
  public ref int PersonaDataPublicCommendsFriendly {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC1D00782B3DA495B));
  }
  public ref int PersonaDataXpTrailLevel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC1D0078228192B7D));
  }
  public ISchemaFixedArray<uint32> EquippedPlayerSprayIDs {
    get => new SchemaFixedArray<uint32>(_Handle + Schema.GetOffset(0xC1D00782CE970C93));
  }
  public ref CUtlVectorEmbeddedNetworkVar< ServerAuthoritativeWeaponSlot_t > ServerAuthoritativeWeaponSlots {
    get => ref _Handle.AsRef<CUtlVectorEmbeddedNetworkVar< ServerAuthoritativeWeaponSlot_t >>(Schema.GetOffset(0xC1D007826EED2FF6));
  }
  public ref CUtlVectorEmbeddedNetworkVar< CSNetworkableLoadout_t > NetworkableLoadout {
    get => ref _Handle.AsRef<CUtlVectorEmbeddedNetworkVar< CSNetworkableLoadout_t >>(Schema.GetOffset(0xC1D0078226705D53));
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
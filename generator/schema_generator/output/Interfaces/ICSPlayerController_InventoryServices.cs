using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayerController_InventoryServices : IPlayerControllerComponent {

  public ref ushort MusicID { get; }
  
  public ref MedalRank_t Rank { get; }
  
  public ref int PersonaDataPublicLevel { get; }
  
  public ref int PersonaDataPublicCommendsLeader { get; }
  
  public ref int PersonaDataPublicCommendsTeacher { get; }
  
  public ref int PersonaDataPublicCommendsFriendly { get; }
  
  public ref int PersonaDataXpTrailLevel { get; }
  
  public ISchemaFixedArray<uint> EquippedPlayerSprayIDs { get; }
  
  public ref CUtlVectorEmbeddedNetworkVar ServerAuthoritativeWeaponSlots { get; }
  
  public ref CUtlVectorEmbeddedNetworkVar NetworkableLoadout { get; }
  
}
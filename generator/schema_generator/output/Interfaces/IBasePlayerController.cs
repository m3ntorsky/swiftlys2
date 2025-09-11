using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBasePlayerController : IBaseEntity {

  
  public ref ulong InButtonsWhichAreToggles { get; }
  
  public ref uint TickBase { get; }
  
  public ref CHandle<CBasePlayerPawn> Pawn { get; }
  
  public ref bool KnownTeamMismatch { get; }
  
  public ref CSplitScreenSlot SplitScreenSlot { get; }
  
  public ref CHandle<CBasePlayerController> SplitOwner { get; }
  
  public ref CUtlVector<CHandle<CBasePlayerController>> SplitScreenPlayers { get; }
  
  public ref bool IsHLTV { get; }
  
  public ref PlayerConnectedState Connected { get; }
  
  public ISchemaFixedString PlayerName { get; }
  
  public ref CUtlString NetworkIDString { get; }
  
  public ref float LerpTime { get; }
  
  public ref bool LagCompensation { get; }
  
  public ref bool Predict { get; }
  
  public ref bool IsLowViolence { get; }
  
  public ref bool GamePaused { get; }
  
  public ref ChatIgnoreType_t IgnoreGlobalChat { get; }
  
  public ref float LastPlayerTalkTime { get; }
  
  public ref float LastEntitySteadyState { get; }
  
  public ref int AvailableEntitySteadyState { get; }
  
  public ref bool HasAnySteadyStateEnts { get; }
  
  public ref ulong SteamID { get; }
  
  public ref bool NoClipEnabled { get; }
  
  public ref uint DesiredFOV { get; }
}
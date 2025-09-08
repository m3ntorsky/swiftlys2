using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMapVetoPickController : IBaseEntity {

  public ref bool PlayedIntroVcd { get; }
  
  public ref bool NeedToPlayFiveSecondsRemaining { get; }
  
  public ref double DblPreMatchDraftSequenceTime { get; }
  
  public ref bool PreMatchDraftStateChanged { get; }
  
  public ref int DraftType { get; }
  
  public ref int TeamWinningCoinToss { get; }
  
  public ISchemaFixedArray<int> TeamWithFirstChoice { get; }
  
  public ISchemaFixedArray<int> VoteMapIdsList { get; }
  
  public ISchemaFixedArray<int> AccountIDs { get; }
  
  public ISchemaFixedArray<int> MapId0 { get; }
  
  public ISchemaFixedArray<int> MapId1 { get; }
  
  public ISchemaFixedArray<int> MapId2 { get; }
  
  public ISchemaFixedArray<int> MapId3 { get; }
  
  public ISchemaFixedArray<int> MapId4 { get; }
  
  public ISchemaFixedArray<int> MapId5 { get; }
  
  public ISchemaFixedArray<int> StartingSide0 { get; }
  
  public ref int CurrentPhase { get; }
  
  public ref int PhaseStartTick { get; }
  
  public ref int PhaseDurationTicks { get; }
  
  public ISchemaUntypedField OnMapVetoed { get; }
  
  public ISchemaUntypedField OnMapPicked { get; }
  
  public ISchemaUntypedField OnSidesPicked { get; }
  
  public ISchemaUntypedField OnNewPhaseStarted { get; }
  
  public ISchemaUntypedField OnLevelTransition { get; }
  
}
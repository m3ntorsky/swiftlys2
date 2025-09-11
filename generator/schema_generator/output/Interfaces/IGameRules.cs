using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGameRules : ISchemaClass {

  
  public INetworkVarChainer __m_pChainEntity { get; }
  
  public ISchemaFixedString QuestName { get; }
  
  public ref int QuestPhase { get; }
  
  public ref int TotalPausedTicks { get; }
  
  public ref int PauseStartTick { get; }
  
  public ref bool GamePaused { get; }
}
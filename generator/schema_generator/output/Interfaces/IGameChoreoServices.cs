using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGameChoreoServices : IIChoreoServices {

  public CHandle<IBaseAnimGraph> Owner { get; }
  
  public CHandle<IScriptedSequence> ScriptedSequence { get; }
  
  public ref IChoreoServices::ScriptState_t ScriptState { get; }
  
  public ref IChoreoServices::ChoreoState_t ChoreoState { get; }
  
  public IGameTime_t TimeStartedState { get; }
  
}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGameChoreoServices : IChoreoServices, IGameChoreoServices {

  public CGameChoreoServices(nint handle) : base(handle) {
  }

  public CHandle<IBaseAnimGraph> Owner {
    get => new CHandle<CBaseAnimGraph>(_Handle + Schema.GetOffset(0xF5FFE2B2F6D89572));
  }
  public CHandle<IScriptedSequence> ScriptedSequence {
    get => new CHandle<CScriptedSequence>(_Handle + Schema.GetOffset(0xF5FFE2B2E43BF85C));
  }
  public ref IChoreoServices::ScriptState_t ScriptState {
    get => ref _Handle.AsRef<IChoreoServices::ScriptState_t>(Schema.GetOffset(0xF5FFE2B2E4CD331F));
  }
  public ref IChoreoServices::ChoreoState_t ChoreoState {
    get => ref _Handle.AsRef<IChoreoServices::ChoreoState_t>(Schema.GetOffset(0xF5FFE2B251730DD8));
  }
  public IGameTime_t TimeStartedState {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xF5FFE2B20BD38900));
  }


}
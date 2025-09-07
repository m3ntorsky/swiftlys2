using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGameChoreoServices : IChoreoServices, IGameChoreoServices {

  public CGameChoreoServices(nint handle) : base(handle) {
  }

  public CGameChoreoServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CBaseAnimGraph > Owner {
    get => ref _Handle.AsRef<CHandle< CBaseAnimGraph >>(Schema.GetOffset(0xF5FFE2B2F6D89572));
  }
  public ref CHandle< CScriptedSequence > ScriptedSequence {
    get => ref _Handle.AsRef<CHandle< CScriptedSequence >>(Schema.GetOffset(0xF5FFE2B2E43BF85C));
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
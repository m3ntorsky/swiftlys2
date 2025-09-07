using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStateMachineUpdateNode : CAnimUpdateNodeBase, IStateMachineUpdateNode {

  public CStateMachineUpdateNode(nint handle) : base(handle) {
  }

  public CStateMachineUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAnimStateMachineUpdater StateMachine {
    get => new CAnimStateMachineUpdater(_Handle + Schema.GetOffset(0xE2E7B91DBB7EEF2F));
  }
  public ref CUtlVector< CStateNodeStateData > StateData {
    get => ref _Handle.AsRef<CUtlVector< CStateNodeStateData >>(Schema.GetOffset(0xE2E7B91D765EA6D6));
  }
  public ref CUtlVector< CStateNodeTransitionData > TransitionData {
    get => ref _Handle.AsRef<CUtlVector< CStateNodeTransitionData >>(Schema.GetOffset(0xE2E7B91D730EEA72));
  }
  public ref bool BlockWaningTags {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE2E7B91DB6999F75));
  }
  public ref bool LockStateWhenWaning {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE2E7B91D105A8C95));
  }
  public ref bool ResetWhenActivated {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xE2E7B91DE7055CF7));
  }


}
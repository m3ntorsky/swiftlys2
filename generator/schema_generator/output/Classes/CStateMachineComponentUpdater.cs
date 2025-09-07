using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStateMachineComponentUpdater : CAnimComponentUpdater, IStateMachineComponentUpdater {

  public CStateMachineComponentUpdater(nint handle) : base(handle) {
  }

  public CStateMachineComponentUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAnimStateMachineUpdater StateMachine {
    get => new CAnimStateMachineUpdater(_Handle + Schema.GetOffset(0x25255200BB7EEF2F));
  }


}
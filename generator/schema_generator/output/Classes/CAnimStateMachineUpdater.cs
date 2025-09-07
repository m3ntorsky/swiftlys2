using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimStateMachineUpdater : SchemaClass, IAnimStateMachineUpdater {

  public CAnimStateMachineUpdater(nint handle) : base(handle) {
  }

  public CAnimStateMachineUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CStateUpdateData > States {
    get => ref _Handle.AsRef<CUtlVector< CStateUpdateData >>(Schema.GetOffset(0xD25DFB766F284CFF));
  }
  public ref CUtlVector< CTransitionUpdateData > Transitions {
    get => ref _Handle.AsRef<CUtlVector< CTransitionUpdateData >>(Schema.GetOffset(0xD25DFB76AD108163));
  }
  public ref int StartStateIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD25DFB762881C68C));
  }


}
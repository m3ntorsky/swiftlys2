using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmStateMachineNode__TransitionDefinition_t : SchemaClass, INmStateMachineNode__TransitionDefinition_t {

  public CNmStateMachineNode__TransitionDefinition_t(nint handle) : base(handle) {
  }

  public ref short TargetStateIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x9404D2C4E5C0218C));
  }
  public ref short ConditionNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x9404D2C4773FE641));
  }
  public ref short TransitionNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x9404D2C40D5CDE45));
  }
  public ref bool CanBeForced {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9404D2C4B6EB0555));
  }


}
using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseScriptedSequenceData_t : SchemaClass, IPulseScriptedSequenceData_t {

  public PulseScriptedSequenceData_t(nint handle) : base(handle) {
  }

  public ref int ActorID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7C7814728383E163));
  }
  public ref CUtlString PreIdleSequence {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x7C781472672B317E));
  }
  public ref CUtlString EntrySequence {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x7C7814722635E511));
  }
  public ref CUtlString Sequence {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x7C78147209FFA3B5));
  }
  public ref CUtlString ExitSequence {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x7C7814725F482845));
  }
  public ref ScriptedMoveTo_t MoveTo {
    get => ref _Handle.AsRef<ScriptedMoveTo_t>(Schema.GetOffset(0x7C781472A9282EB9));
  }
  public ref SharedMovementGait_t MoveToGait {
    get => ref _Handle.AsRef<SharedMovementGait_t>(Schema.GetOffset(0x7C7814721217E084));
  }
  public ref ScriptedHeldWeaponBehavior_t HeldWeaponBehavior {
    get => ref _Handle.AsRef<ScriptedHeldWeaponBehavior_t>(Schema.GetOffset(0x7C781472D545A524));
  }
  public ref bool LoopPreIdleSequence {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7C7814728649E65F));
  }
  public ref bool LoopActionSequence {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7C78147242C7CFA4));
  }
  public ref bool LoopPostIdleSequence {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7C781472C17036CA));
  }
  public ref bool IgnoreLookAt {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7C781472ECC380B5));
  }


}
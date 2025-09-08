using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseScriptedSequenceData_t : ISchemaClass {

  public ref int ActorID { get; }
  
  public ref CUtlString PreIdleSequence { get; }
  
  public ref CUtlString EntrySequence { get; }
  
  public ref CUtlString Sequence { get; }
  
  public ref CUtlString ExitSequence { get; }
  
  public ref ScriptedMoveTo_t MoveTo { get; }
  
  public ref SharedMovementGait_t MoveToGait { get; }
  
  public ref ScriptedHeldWeaponBehavior_t HeldWeaponBehavior { get; }
  
  public ref bool LoopPreIdleSequence { get; }
  
  public ref bool LoopActionSequence { get; }
  
  public ref bool LoopPostIdleSequence { get; }
  
  public ref bool IgnoreLookAt { get; }
  
}
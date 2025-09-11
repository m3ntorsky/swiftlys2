using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_ScriptedSequence : IPulseCell_BaseYieldingInflow {

  
  public ref CUtlString SyncGroup { get; }
  
  public ref int ExpectedNumSequencesInSyncGroup { get; }
  
  public ref bool EnsureOnNavmeshOnFinish { get; }
  
  public ref bool DontTeleportAtEnd { get; }
  
  public ref bool DisallowInterrupts { get; }
  
  public IPulseScriptedSequenceData_t ScriptedSequenceDataMain { get; }
  
// CUtlVector< PulseScriptedSequenceData_t >
  public ref CUtlVector AdditionalActors { get; }
  
  public IPulse_ResumePoint OnFinished { get; }
  
  public IPulse_ResumePoint OnCanceled { get; }
  
// CUtlVector< CPulse_OutflowConnection >
  public ref CUtlVector Triggers { get; }
}
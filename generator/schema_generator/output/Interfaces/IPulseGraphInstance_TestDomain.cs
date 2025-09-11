using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseGraphInstance_TestDomain : IBasePulseGraphInstance {

  
  public ref bool IsRunningUnitTests { get; }
  
  public ref bool ExplicitTimeStepping { get; }
  
  public ref bool ExpectingToDestroyWithYieldedCursors { get; }
  
  public ref bool QuietTracepoints { get; }
  
  public ref bool ExpectingCursorTerminatedDueToMaxInstructions { get; }
  
  public ref int CursorsTerminatedDueToMaxInstructions { get; }
  
  public ref int NextValidateIndex { get; }
  
  public ref CUtlVector<CUtlString> Tracepoints { get; }
  
  public ref bool TestYesOrNoPath { get; }
}
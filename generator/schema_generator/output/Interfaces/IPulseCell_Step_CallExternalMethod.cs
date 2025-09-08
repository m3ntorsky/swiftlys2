using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Step_CallExternalMethod : IPulseCell_BaseYieldingInflow {

  public ISchemaUntypedField MethodName { get; }
  
  public ISchemaUntypedField GameBlackboard { get; }
  
  public ref CUtlLeanVector<CPulseRuntimeMethodArg> ExpectedArgs { get; }
  
  public ref PulseMethodCallMode_t AsyncCallMode { get; }
  
  public IPulse_ResumePoint OnFinished { get; }
  
}
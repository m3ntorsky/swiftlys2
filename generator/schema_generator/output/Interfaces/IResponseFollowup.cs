using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IResponseFollowup : ISchemaClass {

  public ref CString Followup_concept { get; }
  
  public ref CString Followup_contexts { get; }
  
  public ref float Followup_delay { get; }
  
  public ref CString Followup_target { get; }
  
  public ref CString Followup_entityiotarget { get; }
  
  public ref CString Followup_entityioinput { get; }
  
  public ref float Followup_entityiodelay { get; }
  
  public ref bool Fired { get; }
  
}
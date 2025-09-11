using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixDelayDesc_t : ISchemaClass {

  
  public IVMixFilterDesc_t FeedbackFilter { get; }
  
  public ref bool EnableFilter { get; }
  
  public ref float Delay { get; }
  
  public ref float DirectGain { get; }
  
  public ref float DelayGain { get; }
  
  public ref float FeedbackGain { get; }
  
  public ref float Width { get; }
}
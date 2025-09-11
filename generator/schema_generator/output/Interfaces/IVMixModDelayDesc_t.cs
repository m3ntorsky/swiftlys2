using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixModDelayDesc_t : ISchemaClass {

  
  public IVMixFilterDesc_t FeedbackFilter { get; }
  
  public ref bool PhaseInvert { get; }
  
  public ref float GlideTime { get; }
  
  public ref float Delay { get; }
  
  public ref float OutputGain { get; }
  
  public ref float FeedbackGain { get; }
  
  public ref float ModRate { get; }
  
  public ref float ModDepth { get; }
  
  public ref bool ApplyAntialiasing { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixBoxverb2Desc_t : ISchemaClass {

  
  public ref float SizeMax { get; }
  
  public ref float SizeMin { get; }
  
  public ref float Complexity { get; }
  
  public ref float Diffusion { get; }
  
  public ref float ModDepth { get; }
  
  public ref float ModRate { get; }
  
  public ref bool Parallel { get; }
  
  public IVMixFilterDesc_t FilterType { get; }
  
  public ref float Width { get; }
  
  public ref float Height { get; }
  
  public ref float Depth { get; }
  
  public ref float FeedbackScale { get; }
  
  public ref float FeedbackWidth { get; }
  
  public ref float FeedbackHeight { get; }
  
  public ref float FeedbackDepth { get; }
  
  public ref float OutputGain { get; }
  
  public ref float Taps { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixPlateverbDesc_t : ISchemaClass {

  public ref float Prefilter { get; }
  
  public ref float InputDiffusion1 { get; }
  
  public ref float InputDiffusion2 { get; }
  
  public ref float Decay { get; }
  
  public ref float Damp { get; }
  
  public ref float FeedbackDiffusion1 { get; }
  
  public ref float FeedbackDiffusion2 { get; }
  
}
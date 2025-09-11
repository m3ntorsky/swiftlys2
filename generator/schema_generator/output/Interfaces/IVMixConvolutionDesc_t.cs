using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixConvolutionDesc_t : ISchemaClass {

  
  public ref float FldbGain { get; }
  
  public ref float PreDelayMS { get; }
  
  public ref float WetMix { get; }
  
  public ref float FldbLow { get; }
  
  public ref float FldbMid { get; }
  
  public ref float FldbHigh { get; }
  
  public ref float LowCutoffFreq { get; }
  
  public ref float HighCutoffFreq { get; }
}
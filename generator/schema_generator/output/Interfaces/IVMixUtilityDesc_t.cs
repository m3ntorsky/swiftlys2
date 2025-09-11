using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixUtilityDesc_t : ISchemaClass {

  
  public ref VMixChannelOperation_t Op { get; }
  
  public ref float InputPan { get; }
  
  public ref float OutputBalance { get; }
  
  public ref float FldbOutputGain { get; }
  
  public ref bool BassMono { get; }
  
  public ref float BassFreq { get; }
}
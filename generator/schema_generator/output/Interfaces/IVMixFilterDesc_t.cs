using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixFilterDesc_t : ISchemaClass {

  
  public ref VMixFilterType_t FilterType { get; }
  
  public ref VMixFilterSlope_t FilterSlope { get; }
  
  public ref bool Enabled { get; }
  
  public ref float FldbGain { get; }
  
  public ref float CutoffFreq { get; }
  
  public ref float Q { get; }
}
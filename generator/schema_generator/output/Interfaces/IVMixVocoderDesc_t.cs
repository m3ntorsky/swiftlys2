using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixVocoderDesc_t : ISchemaClass {

  public ref int BandCount { get; }
  
  public ref float Bandwidth { get; }
  
  public ref float FldBModGain { get; }
  
  public ref float FreqRangeStart { get; }
  
  public ref float FreqRangeEnd { get; }
  
  public ref float FldBUnvoicedGain { get; }
  
  public ref float AttackTimeMS { get; }
  
  public ref float ReleaseTimeMS { get; }
  
  public ref int DebugBand { get; }
  
  public ref bool PeakMode { get; }
  
}
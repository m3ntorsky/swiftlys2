using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixDynamicsCompressorDesc_t : ISchemaClass {

  public ref float FldbOutputGain { get; }
  
  public ref float FldbCompressionThreshold { get; }
  
  public ref float FldbKneeWidth { get; }
  
  public ref float CompressionRatio { get; }
  
  public ref float AttackTimeMS { get; }
  
  public ref float ReleaseTimeMS { get; }
  
  public ref float RMSTimeMS { get; }
  
  public ref float WetMix { get; }
  
  public ref bool PeakMode { get; }
  
}
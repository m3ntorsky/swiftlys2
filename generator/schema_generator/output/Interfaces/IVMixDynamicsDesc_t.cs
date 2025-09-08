using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixDynamicsDesc_t : ISchemaClass {

  public ref float FldbGain { get; }
  
  public ref float FldbNoiseGateThreshold { get; }
  
  public ref float FldbCompressionThreshold { get; }
  
  public ref float FldbLimiterThreshold { get; }
  
  public ref float FldbKneeWidth { get; }
  
  public ref float Ratio { get; }
  
  public ref float LimiterRatio { get; }
  
  public ref float AttackTimeMS { get; }
  
  public ref float ReleaseTimeMS { get; }
  
  public ref float RMSTimeMS { get; }
  
  public ref float WetMix { get; }
  
  public ref bool PeakMode { get; }
  
}
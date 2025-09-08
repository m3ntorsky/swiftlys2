using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixDynamics3BandDesc_t : ISchemaClass {

  public ref float FldbGainOutput { get; }
  
  public ref float RMSTimeMS { get; }
  
  public ref float FldbKneeWidth { get; }
  
  public ref float Depth { get; }
  
  public ref float WetMix { get; }
  
  public ref float TimeScale { get; }
  
  public ref float LowCutoffFreq { get; }
  
  public ref float HighCutoffFreq { get; }
  
  public ref bool PeakMode { get; }
  
  public IVMixDynamicsBand_t BandDesc { get; }
  
}
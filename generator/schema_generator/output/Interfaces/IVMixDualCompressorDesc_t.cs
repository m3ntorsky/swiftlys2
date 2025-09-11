using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixDualCompressorDesc_t : ISchemaClass {

  
  public ref float RMSTimeMS { get; }
  
  public ref float FldbKneeWidth { get; }
  
  public ref float WetMix { get; }
  
  public ref bool PeakMode { get; }
  
  public IVMixDynamicsBand_t BandDesc { get; }
}
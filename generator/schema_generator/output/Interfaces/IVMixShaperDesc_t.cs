using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixShaperDesc_t : ISchemaClass {

  
  public ref int Shape { get; }
  
  public ref float FldbDrive { get; }
  
  public ref float FldbOutputGain { get; }
  
  public ref float WetMix { get; }
  
  public ref int OversampleFactor { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixPitchShiftDesc_t : ISchemaClass {

  public ref int GrainSampleCount { get; }
  
  public ref float PitchShift { get; }
  
  public ref int Quality { get; }
  
  public ref int ProcType { get; }
  
}
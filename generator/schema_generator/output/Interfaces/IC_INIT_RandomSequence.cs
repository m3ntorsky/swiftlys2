using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomSequence : IParticleFunctionInitializer {

  public ref int SequenceMin { get; }
  
  public ref int SequenceMax { get; }
  
  public ref bool Shuffle { get; }
  
  public ref bool Linear { get; }
  
  public ref CUtlVector WeightedList { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INetworkedSequenceOperation : ISchemaClass {

  
  public IHSequence Sequence { get; }
  
  public ref float PrevCycle { get; }
  
  public ref float Cycle { get; }
  
  public ref CNetworkedQuantizedFloat Weight { get; }
  
  public ref bool SequenceChangeNetworked { get; }
  
  public ref bool Discontinuity { get; }
  
  public ref float PrevCycleFromDiscontinuity { get; }
  
  public ref float PrevCycleForAnimEventDetection { get; }
}
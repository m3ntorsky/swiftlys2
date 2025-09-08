using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_CycleShuffled : IPulseCell_BaseFlow {

  public ref CUtlVector Outputs { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Outflow_CycleShuffled__InstanceState_t : ISchemaClass {

  
  public ref CUtlVectorFixedGrowable<byte> Shuffle { get; }
  
  public ref int NextShuffle { get; }
}
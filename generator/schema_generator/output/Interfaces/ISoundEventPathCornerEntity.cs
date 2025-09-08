using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundEventPathCornerEntity : ISoundEventEntity {

  public ref CUtlSymbolLarge PathCorner { get; }
  
  public ref int CountMax { get; }
  
  public ref float DistanceMax { get; }
  
  public ref float DistMaxSqr { get; }
  
  public ref float DotProductMax { get; }
  
  public ref bool Playing { get; }
  
  public ref CUtlVector CornerPairsNetworked { get; }
  
}
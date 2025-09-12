using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundEventPathCornerEntity : ISoundEventEntity {

  
  public ISchemaUntypedField PathCorner { get; }
  
  public ref int CountMax { get; }
  
  public ref float DistanceMax { get; }
  
  public ref float DistMaxSqr { get; }
  
  public ref float DotProductMax { get; }
  
  public ref bool Playing { get; }
  
// CNetworkUtlVectorBase< SoundeventPathCornerPairNetworked_t >
  public ref CUtlVector CornerPairsNetworked { get; }
}
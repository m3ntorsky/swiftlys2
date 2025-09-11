using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundOpvarSetPathCornerEntity : ISoundOpvarSetPointEntity {

  
  public ref float DistMinSqr { get; }
  
  public ref float DistMaxSqr { get; }
  
  public ref CUtlSymbolLarge PathCornerEntityName { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointGamestatsCounter : IPointEntity {

  public ref CUtlSymbolLarge StrStatisticName { get; }
  
  public ref bool Disabled { get; }
  
}
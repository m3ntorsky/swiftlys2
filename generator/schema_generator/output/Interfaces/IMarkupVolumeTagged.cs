using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMarkupVolumeTagged : IMarkupVolume {

  public ref CUtlVector<CGlobalSymbol> GroupNames { get; }
  
  public ref CUtlVector<CGlobalSymbol> Tags { get; }
  
  public ref bool IsGroup { get; }
  
  public ref bool GroupByPrefab { get; }
  
  public ref bool GroupByVolume { get; }
  
  public ref bool GroupOtherGroups { get; }
  
  public ref bool IsInGroup { get; }
  
}
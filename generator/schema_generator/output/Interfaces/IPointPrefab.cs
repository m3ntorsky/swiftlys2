using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointPrefab : IServerOnlyPointEntity {

  public ref CUtlSymbolLarge TargetMapName { get; }
  
  public ref CUtlSymbolLarge ForceWorldGroupID { get; }
  
  public ref CUtlSymbolLarge AssociatedRelayTargetName { get; }
  
  public ref bool FixupNames { get; }
  
  public ref bool LoadDynamic { get; }
  
  public CHandle<IPointPrefab> AssociatedRelayEntity { get; }
  
}
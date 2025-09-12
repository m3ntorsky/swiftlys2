using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointPrefab : IServerOnlyPointEntity {

  
  public ISchemaUntypedField TargetMapName { get; }
  
  public ISchemaUntypedField ForceWorldGroupID { get; }
  
  public ISchemaUntypedField AssociatedRelayTargetName { get; }
  
  public ref bool FixupNames { get; }
  
  public ref bool LoadDynamic { get; }
  
  public ref CHandle<CPointPrefab> AssociatedRelayEntity { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointTemplate : ILogicalEntity {

  public ref CUtlSymbolLarge WorldName { get; }
  
  public ref CUtlSymbolLarge Source2EntityLumpName { get; }
  
  public ref CUtlSymbolLarge EntityFilterName { get; }
  
  public ref float TimeoutInterval { get; }
  
  public ref bool AsynchronouslySpawnEntities { get; }
  
  public ref PointTemplateClientOnlyEntityBehavior_t ClientOnlyEntityBehavior { get; }
  
  public ref PointTemplateOwnerSpawnGroupType_t OwnerSpawnGroupType { get; }
  
  public ref CUtlVector<uint> CreatedSpawnGroupHandles { get; }
  
  public ref CUtlVector<CEntityHandle> SpawnedEntityHandles { get; }
  
  public ISchemaUntypedField ScriptSpawnCallback { get; }
  
  public ISchemaUntypedField ScriptCallbackScope { get; }
  
}
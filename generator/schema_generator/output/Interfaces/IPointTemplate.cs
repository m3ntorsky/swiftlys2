using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointTemplate : ILogicalEntity {

  
  public ISchemaUntypedField WorldName { get; }
  
  public ISchemaUntypedField Source2EntityLumpName { get; }
  
  public ISchemaUntypedField EntityFilterName { get; }
  
  public ref float TimeoutInterval { get; }
  
  public ref bool AsynchronouslySpawnEntities { get; }
  
  public ref PointTemplateClientOnlyEntityBehavior_t ClientOnlyEntityBehavior { get; }
  
  public ref PointTemplateOwnerSpawnGroupType_t OwnerSpawnGroupType { get; }
  
  public ref CUtlVector<uint> CreatedSpawnGroupHandles { get; }
  
  public ref CUtlVector<CHandle<IEntityInstance>> SpawnedEntityHandles { get; }
  
  public ISchemaUntypedField ScriptSpawnCallback { get; }
  
  public ISchemaUntypedField ScriptCallbackScope { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundOpvarSetPointBase : IBaseEntity {

  
  public ref bool Disabled { get; }
  
  public ref CHandle<IEntityInstance> Source { get; }
  
  public ISchemaUntypedField SourceEntityName { get; }
  
  public ref Vector LastPosition { get; }
  
  public ISchemaUntypedField StackName { get; }
  
  public ISchemaUntypedField OperatorName { get; }
  
  public ISchemaUntypedField OpvarName { get; }
  
  public ref int OpvarIndex { get; }
  
  public ref bool UseAutoCompare { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicLineToEntity : ILogicalEntity {

  
  public ISchemaUntypedField Line { get; }
  
  public ISchemaUntypedField SourceName { get; }
  
  public ref CHandle<CBaseEntity> StartEntity { get; }
  
  public ref CHandle<CBaseEntity> EndEntity { get; }
}
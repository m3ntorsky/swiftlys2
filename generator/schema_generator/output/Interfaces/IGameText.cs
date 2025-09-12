using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGameText : IRulePointEntity {

  
  public ISchemaUntypedField Message { get; }
  
  public Ihudtextparms_t TextParms { get; }
}
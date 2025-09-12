using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseGraphInstance_ServerEntity : IBasePulseGraphInstance {

  
  public ref CHandle<CBaseEntity> Owner { get; }
  
  public ref bool Activated { get; }
  
  public ISchemaUntypedField NameFixupStaticPrefix { get; }
  
  public ISchemaUntypedField NameFixupParent { get; }
  
  public ISchemaUntypedField NameFixupLocal { get; }
  
  public ISchemaUntypedField ProceduralWorldNameForRelays { get; }
}
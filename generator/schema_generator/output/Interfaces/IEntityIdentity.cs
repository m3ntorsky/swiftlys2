using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEntityIdentity : ISchemaClass {

  
  public ref int NameStringableIndex { get; }
  
  public ISchemaUntypedField Name { get; }
  
  public ISchemaUntypedField DesignerName { get; }
  
  public ref uint Flags { get; }
  
  public ref uint WorldGroupId { get; }
  
  public ref uint DataObjectTypes { get; }
  
  public IChangeAccessorFieldPathIndex_t PathIndex { get; }
  
  public IEntityIdentity Prev { get; }
  
  public IEntityIdentity Next { get; }
  
  public IEntityIdentity PrevByClass { get; }
  
  public IEntityIdentity NextByClass { get; }
}
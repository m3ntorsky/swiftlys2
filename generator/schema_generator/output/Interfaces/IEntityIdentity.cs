using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEntityIdentity : ISchemaClass {

  public ref int NameStringableIndex { get; }
  
  public ref CUtlSymbolLarge Name { get; }
  
  public ref CUtlSymbolLarge DesignerName { get; }
  
  public ref uint Flags { get; }
  
  public ref WorldGroupId_t WorldGroupId { get; }
  
  public ref uint DataObjectTypes { get; }
  
  public IChangeAccessorFieldPathIndex_t PathIndex { get; }
  
  public IEntityIdentity Prev { get; }
  
  public IEntityIdentity Next { get; }
  
  public IEntityIdentity PrevByClass { get; }
  
  public IEntityIdentity NextByClass { get; }
  
}
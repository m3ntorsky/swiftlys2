using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEntityComponentHelper : ISchemaClass {

  
  public ref uint Flags { get; }
  
  public IEntComponentInfo_t Info { get; }
  
  public ref int Priority { get; }
  
  public IEntityComponentHelper Next { get; }
}
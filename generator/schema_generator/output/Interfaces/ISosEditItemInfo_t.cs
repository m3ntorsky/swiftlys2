using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosEditItemInfo_t : ISchemaClass {

  
  public ref SosEditItemType_t ItemType { get; }
  
  public ref CUtlString ItemName { get; }
  
  public ref CUtlString ItemTypeName { get; }
  
  public ref CUtlString ItemKVString { get; }
  
  public ref Vector2D ItemPos { get; }
}
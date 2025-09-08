using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IConfigIndex : ISchemaClass {

  public ref ushort Group { get; }
  
  public ref ushort Config { get; }
  
}
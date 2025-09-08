using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Ihudtextparms_t : ISchemaClass {

  public ref Color Color1 { get; }
  
  public ref Color Color2 { get; }
  
  public ref byte Effect { get; }
  
  public ref byte Channel { get; }
  
  public ref float X { get; }
  
  public ref float Y { get; }
  
}
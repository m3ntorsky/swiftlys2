using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFourVectors2D : ISchemaClass {

  
  public ref fltx4 X { get; }
  
  public ref fltx4 Y { get; }
}
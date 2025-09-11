using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFourQuaternions : ISchemaClass {

  
  public ref fltx4 X { get; }
  
  public ref fltx4 Y { get; }
  
  public ref fltx4 Z { get; }
  
  public ref fltx4 W { get; }
}
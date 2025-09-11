using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimMovement : ISchemaClass {

  
  public ref int Endframe { get; }
  
  public ref int Motionflags { get; }
  
  public ref float V0 { get; }
  
  public ref float V1 { get; }
  
  public ref float Angle { get; }
  
  public ref Vector Vector { get; }
  
  public ref Vector Position { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseTurtleGraphicsCursor : IPulseExecCursor {

  
  public ref Color Color { get; }
  
  public ref Vector2D Pos { get; }
  
  public ref float HeadingDeg { get; }
  
  public ref bool PenUp { get; }
}
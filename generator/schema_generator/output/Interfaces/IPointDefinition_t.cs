using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointDefinition_t : ISchemaClass {

  public ref int ControlPoint { get; }
  
  public ref bool LocalCoords { get; }
  
  public ref Vector Offset { get; }
  
}
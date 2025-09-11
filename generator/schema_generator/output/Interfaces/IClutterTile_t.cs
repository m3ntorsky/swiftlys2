using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IClutterTile_t : ISchemaClass {

  
  public ref uint FirstInstance { get; }
  
  public ref uint LastInstance { get; }
  
  public IAABB_t BoundsWs { get; }
}
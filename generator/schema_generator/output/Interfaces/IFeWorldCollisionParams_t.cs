using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeWorldCollisionParams_t : ISchemaClass {

  
  public ref float WorldFriction { get; }
  
  public ref float GroundFriction { get; }
  
  public ref ushort ListBegin { get; }
  
  public ref ushort ListEnd { get; }
}
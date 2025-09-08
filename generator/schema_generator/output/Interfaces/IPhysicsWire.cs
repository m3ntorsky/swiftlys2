using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysicsWire : IBaseEntity {

  public ref int Density { get; }
  
}
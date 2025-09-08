using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysThruster : IPhysForce {

  public ref Vector LocalOrigin { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysTorque : IPhysForce {

  public ref Vector Axis { get; }
  
}
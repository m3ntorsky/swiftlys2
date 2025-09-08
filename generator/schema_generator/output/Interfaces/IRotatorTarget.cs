using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRotatorTarget : IPointEntity {

  public IEntityIOOutput OnArrivedAt { get; }
  
  public ref RotatorTargetSpace_t Space { get; }
  
}
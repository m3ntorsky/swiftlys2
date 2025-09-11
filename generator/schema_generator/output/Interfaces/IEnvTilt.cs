using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvTilt : IPointEntity {

  
  public ref float Duration { get; }
  
  public ref float Radius { get; }
  
  public ref float TiltTime { get; }
  
  public IGameTime_t StopTime { get; }
}
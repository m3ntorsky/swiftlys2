using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVelocitySampler : ISchemaClass {

  
  public ref Vector PrevSample { get; }
  
  public IGameTime_t PrevSampleTime { get; }
  
  public ref float IdealSampleRate { get; }
}
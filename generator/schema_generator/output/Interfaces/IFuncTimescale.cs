using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncTimescale : IBaseEntity {

  
  public ref float DesiredTimescale { get; }
  
  public ref float Acceleration { get; }
  
  public ref float MinBlendRate { get; }
  
  public ref float BlendDeltaMultiplier { get; }
  
  public ref bool IsStarted { get; }
}
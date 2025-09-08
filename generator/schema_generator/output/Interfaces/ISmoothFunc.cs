using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISmoothFunc : ISchemaClass {

  public ref float SmoothAmplitude { get; }
  
  public ref float SmoothBias { get; }
  
  public ref float SmoothDuration { get; }
  
  public ref float SmoothRemainingTime { get; }
  
  public ref int SmoothDir { get; }
  
}
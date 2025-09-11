using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWorldBuilderParams_t : ISchemaClass {

  
  public ref float MinDrawVolumeSize { get; }
  
  public ref bool BuildBakedLighting { get; }
  
  public ref bool AggregateInstanceStreams { get; }
  
  public IBakedLightingInfo_t BakedLightingInfo { get; }
  
  public ref ulong CompileTimestamp { get; }
  
  public ref ulong CompileFingerprint { get; }
}
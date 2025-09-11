using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerStaticAdditiveSynth__CGainScalePerInstance : ISchemaClass {

  
  public ref float MinVolume { get; }
  
  public ref int InstancesAtMinVolume { get; }
  
  public ref float MaxVolume { get; }
  
  public ref int InstancesAtMaxVolume { get; }
}
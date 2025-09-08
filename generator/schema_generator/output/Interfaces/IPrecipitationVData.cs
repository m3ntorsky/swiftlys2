using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPrecipitationVData : IEntitySubclassVDataBase {

  public ISchemaUntypedField ParticlePrecipitationEffect { get; }
  
  public ref float InnerDistance { get; }
  
  public ref ParticleAttachment_t AttachType { get; }
  
  public ref bool BatchSameVolumeType { get; }
  
  public ref int RTEnvCP { get; }
  
  public ref int RTEnvCPComponent { get; }
  
  public ref CUtlString Modifier { get; }
  
}
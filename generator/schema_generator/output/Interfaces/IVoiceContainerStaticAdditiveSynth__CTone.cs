using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVoiceContainerStaticAdditiveSynth__CTone : ISchemaClass {

  public ref CUtlVector Harmonics { get; }
  
  public ISchemaUntypedField Curve { get; }
  
  public ref bool SyncInstances { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAudioSentence : ISchemaClass {

  public ref bool ShouldVoiceDuck { get; }
  
  public ref CUtlVector RunTimePhonemes { get; }
  
  public ref CUtlVector EmphasisSamples { get; }
  
  public IAudioMorphData MorphData { get; }
  
}
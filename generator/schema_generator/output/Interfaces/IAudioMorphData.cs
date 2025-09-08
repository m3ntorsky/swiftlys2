using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAudioMorphData : ISchemaClass {

  public ref CUtlVector<float> Times { get; }
  
  public ref CUtlVector<uint> NameHashCodes { get; }
  
  public ref CUtlVector<CUtlString> NameStrings { get; }
  
  public ref CUtlVector<CUtlVector<float>> Samples { get; }
  
  public ref float EaseIn { get; }
  
  public ref float EaseOut { get; }
  
}
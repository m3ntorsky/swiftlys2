using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMoodVData : ISchemaClass {

  public ISchemaUntypedField ModelName { get; }
  
  public ref MoodType_t MoodType { get; }
  
  public ref CUtlVector AnimationLayers { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAudioPhonemeTag : ISchemaClass {

  public ref float StartTime { get; }
  
  public ref float EndTime { get; }
  
  public ref int PhonemeCode { get; }
  
}
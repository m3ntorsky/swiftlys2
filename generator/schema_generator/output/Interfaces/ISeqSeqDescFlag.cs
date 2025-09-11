using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqSeqDescFlag : ISchemaClass {

  
  public ref bool Looping { get; }
  
  public ref bool Snap { get; }
  
  public ref bool Autoplay { get; }
  
  public ref bool Post { get; }
  
  public ref bool Hidden { get; }
  
  public ref bool Multi { get; }
  
  public ref bool LegacyDelta { get; }
  
  public ref bool LegacyWorldspace { get; }
  
  public ref bool LegacyCyclepose { get; }
  
  public ref bool LegacyRealtime { get; }
  
  public ref bool ModelDoc { get; }
}
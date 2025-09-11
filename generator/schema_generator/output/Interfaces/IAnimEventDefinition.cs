using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimEventDefinition : ISchemaClass {

  
  public ref int Frame { get; }
  
  public ref int EndFrame { get; }
  
  public ref float Cycle { get; }
  
  public ref float Duration { get; }
  
  public ISchemaUntypedField EventData { get; }
  
  public ref CBufferString LegacyOptions { get; }
  
  public ref CGlobalSymbol EventName { get; }
}
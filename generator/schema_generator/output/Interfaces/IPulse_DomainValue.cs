using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_DomainValue : ISchemaClass {

  
  public ref PulseDomainValueType_t Type { get; }
  
  public ref CGlobalSymbolCaseSensitive Value { get; }
  
  public ISchemaUntypedField RequiredRuntimeType { get; }
}
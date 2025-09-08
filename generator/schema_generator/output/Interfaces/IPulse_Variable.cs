using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulse_Variable : ISchemaClass {

  public ISchemaUntypedField Name { get; }
  
  public ref CUtlString Description { get; }
  
  public ISchemaUntypedField Type { get; }
  
  public ISchemaUntypedField DefaultValue { get; }
  
  public ref PulseVariableKeysSource_t KeysSource { get; }
  
  public ref bool IsPublicBlackboardVariable { get; }
  
  public ref bool IsObservable { get; }
  
  public IPulseDocNodeID_t EditorNodeID { get; }
  
}
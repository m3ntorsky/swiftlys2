using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleVariableRef : ISchemaClass {

  public ISchemaUntypedField VariableName { get; }
  
  public ref PulseValueType_t VariableType { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMaterialVariable_t : ISchemaClass {

  public ref CUtlString StrVariable { get; }
  
  public IParticleAttributeIndex_t VariableField { get; }
  
  public ref float Scale { get; }
  
}
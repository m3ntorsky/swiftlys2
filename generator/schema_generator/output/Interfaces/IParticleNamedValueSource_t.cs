using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleNamedValueSource_t : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref bool IsPublic { get; }
  
  public ref PulseValueType_t ValueType { get; }
  
  public IParticleNamedValueConfiguration_t DefaultConfig { get; }
  
// CUtlVector< ParticleNamedValueConfiguration_t >
  public ref CUtlVector NamedConfigs { get; }
}
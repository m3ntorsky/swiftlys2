using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleModelInput : IParticleInput {

  
  public ref ParticleModelType_t Type { get; }
  
  public ISchemaUntypedField NamedValue { get; }
  
  public ref int ControlPoint { get; }
}
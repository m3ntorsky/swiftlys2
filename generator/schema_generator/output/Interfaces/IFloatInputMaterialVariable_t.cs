using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFloatInputMaterialVariable_t : ISchemaClass {

  
  public ref CUtlString StrVariable { get; }
  
  public IParticleCollectionFloatInput Input { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVecInputMaterialVariable_t : ISchemaClass {

  public ref CUtlString StrVariable { get; }
  
  public IParticleCollectionVecInput Input { get; }
  
}
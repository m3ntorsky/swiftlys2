using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RemapNamedModelElementToScalar : IParticleFunctionInitializer {

  public ref CStrongHandle<InfoForResourceTypeCModel> Model { get; }
  
  public ref CUtlVector<CUtlString> Names { get; }
  
  public ref CUtlVector<float> Values { get; }
  
  public IParticleAttributeIndex_t FieldInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref ParticleSetMethod_t SetMethod { get; }
  
  public ref bool ModelFromRenderer { get; }
  
}
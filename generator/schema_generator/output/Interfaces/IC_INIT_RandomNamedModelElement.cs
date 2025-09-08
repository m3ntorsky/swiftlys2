using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_RandomNamedModelElement : IParticleFunctionInitializer {

  public ref CStrongHandle<InfoForResourceTypeCModel> Model { get; }
  
  public ref CUtlVector<CUtlString> Names { get; }
  
  public ref bool Shuffle { get; }
  
  public ref bool Linear { get; }
  
  public ref bool ModelFromRenderer { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapNamedModelElementOnceTimed : IParticleFunctionOperator {

  public ref CStrongHandle<InfoForResourceTypeCModel> Model { get; }
  
  public ref CUtlVector<CUtlString> InNames { get; }
  
  public ref CUtlVector<CUtlString> OutNames { get; }
  
  public ref CUtlVector<CUtlString> FallbackNames { get; }
  
  public ref bool ModelFromRenderer { get; }
  
  public ref bool Proportional { get; }
  
  public IParticleAttributeIndex_t FieldInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float RemapTime { get; }
  
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_CalculateVectorAttribute : IParticleFunctionOperator {

  
  public ref Vector StartValue { get; }
  
  public IParticleAttributeIndex_t FieldInput1 { get; }
  
  public ref float InputScale1 { get; }
  
  public IParticleAttributeIndex_t FieldInput2 { get; }
  
  public ref float InputScale2 { get; }
  
  public IControlPointReference_t ControlPointInput1 { get; }
  
  public ref float ControlPointScale1 { get; }
  
  public IControlPointReference_t ControlPointInput2 { get; }
  
  public ref float ControlPointScale2 { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref Vector FinalOutputScale { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RenderAsModels : IParticleFunctionRenderer {

  public ref CUtlVector ModelList { get; }
  
  public ref float ModelScale { get; }
  
  public ref bool FitToModelSize { get; }
  
  public ref bool NonUniformScaling { get; }
  
  public IParticleAttributeIndex_t XAxisScalingAttribute { get; }
  
  public IParticleAttributeIndex_t YAxisScalingAttribute { get; }
  
  public IParticleAttributeIndex_t ZAxisScalingAttribute { get; }
  
  public ref int SizeCullBloat { get; }
  
}
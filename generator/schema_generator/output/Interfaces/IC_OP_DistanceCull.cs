using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_DistanceCull : IParticleFunctionOperator {

  public ref int ControlPoint { get; }
  
  public ref Vector PointOffset { get; }
  
  public ref float Distance { get; }
  
  public ref bool CullInside { get; }
  
  public IParticleAttributeIndex_t Attribute { get; }
  
}
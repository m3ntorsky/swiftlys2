using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapDistanceToLineSegmentToScalar : IC_OP_RemapDistanceToLineSegmentBase {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref float MinOutputValue { get; }
  
  public ref float MaxOutputValue { get; }
  
}
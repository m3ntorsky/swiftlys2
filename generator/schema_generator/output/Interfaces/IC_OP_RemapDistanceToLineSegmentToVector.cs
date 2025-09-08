using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapDistanceToLineSegmentToVector : IC_OP_RemapDistanceToLineSegmentBase {

  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref Vector MinOutputValue { get; }
  
  public ref Vector MaxOutputValue { get; }
  
}
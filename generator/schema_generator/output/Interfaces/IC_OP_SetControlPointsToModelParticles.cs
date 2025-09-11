using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointsToModelParticles : IParticleFunctionOperator {

  
  public ISchemaFixedString HitboxSetName { get; }
  
  public ISchemaFixedString AttachmentName { get; }
  
  public ref int FirstControlPoint { get; }
  
  public ref int NumControlPoints { get; }
  
  public ref int FirstSourcePoint { get; }
  
  public ref bool Skin { get; }
  
  public ref bool Attachment { get; }
}
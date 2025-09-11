using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_MovementRigidAttachToCP : IParticleFunctionOperator {

  
  public ref int ControlPointNumber { get; }
  
  public ref int ScaleControlPoint { get; }
  
  public ref int ScaleCPField { get; }
  
  public IParticleAttributeIndex_t FieldInput { get; }
  
  public IParticleAttributeIndex_t FieldOutput { get; }
  
  public ref bool OffsetLocal { get; }
}
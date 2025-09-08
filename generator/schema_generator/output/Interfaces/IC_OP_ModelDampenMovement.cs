using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ModelDampenMovement : IParticleFunctionOperator {

  public ref int ControlPointNumber { get; }
  
  public ref bool BoundBox { get; }
  
  public ref bool Outside { get; }
  
  public ref bool UseBones { get; }
  
  public ISchemaFixedString HitboxSetName { get; }
  
  public IPerParticleVecInput PosOffset { get; }
  
  public ref float Drag { get; }
  
}
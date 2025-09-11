using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SnapshotSkinToBones : IParticleFunctionOperator {

  
  public ref bool TransformNormals { get; }
  
  public ref bool TransformRadii { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref float LifeTimeFadeStart { get; }
  
  public ref float LifeTimeFadeEnd { get; }
  
  public ref float JumpThreshold { get; }
  
  public ref float PrevPosScale { get; }
}
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFollowPathUpdateNode : IUnaryUpdateNode {

  public ref float BlendOutTime { get; }
  
  public ref bool BlockNonPathMovement { get; }
  
  public ref bool StopFeetAtGoal { get; }
  
  public ref bool ScaleSpeed { get; }
  
  public ref float Scale { get; }
  
  public ref float MinAngle { get; }
  
  public ref float MaxAngle { get; }
  
  public ref float SpeedScaleBlending { get; }
  
  public IAnimInputDamping TurnDamping { get; }
  
  public ref AnimValueSource FacingTarget { get; }
  
  public IAnimParamHandle Param { get; }
  
  public ref float TurnToFaceOffset { get; }
  
  public ref bool TurnToFace { get; }
  
}
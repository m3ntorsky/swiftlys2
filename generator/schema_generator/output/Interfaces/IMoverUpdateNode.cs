using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMoverUpdateNode : IUnaryUpdateNode {

  
  public IAnimInputDamping Damping { get; }
  
  public ref AnimValueSource FacingTarget { get; }
  
  public IAnimParamHandle MoveVecParam { get; }
  
  public IAnimParamHandle MoveHeadingParam { get; }
  
  public IAnimParamHandle TurnToFaceParam { get; }
  
  public ref float TurnToFaceOffset { get; }
  
  public ref float TurnToFaceLimit { get; }
  
  public ref bool Additive { get; }
  
  public ref bool ApplyMovement { get; }
  
  public ref bool OrientMovement { get; }
  
  public ref bool ApplyRotation { get; }
  
  public ref bool LimitOnly { get; }
}
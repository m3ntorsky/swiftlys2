using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILookAtOpFixedSettings_t : ISchemaClass {

  public IAnimAttachment Attachment { get; }
  
  public IAnimInputDamping Damping { get; }
  
  public ref CUtlVector Bones { get; }
  
  public ref float YawLimit { get; }
  
  public ref float PitchLimit { get; }
  
  public ref float HysteresisInnerAngle { get; }
  
  public ref float HysteresisOuterAngle { get; }
  
  public ref bool RotateYawForward { get; }
  
  public ref bool MaintainUpDirection { get; }
  
  public ref bool TargetIsPosition { get; }
  
  public ref bool UseHysteresis { get; }
  
}
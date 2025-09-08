using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILookComponentUpdater : IAnimComponentUpdater {

  public IAnimParamHandle LookHeading { get; }
  
  public IAnimParamHandle LookHeadingNormalized { get; }
  
  public IAnimParamHandle LookHeadingVelocity { get; }
  
  public IAnimParamHandle LookPitch { get; }
  
  public IAnimParamHandle LookDistance { get; }
  
  public IAnimParamHandle LookDirection { get; }
  
  public IAnimParamHandle LookTarget { get; }
  
  public IAnimParamHandle LookTargetWorldSpace { get; }
  
  public ref bool NetworkLookTarget { get; }
  
}
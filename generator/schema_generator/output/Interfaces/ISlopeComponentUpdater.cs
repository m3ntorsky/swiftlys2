using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISlopeComponentUpdater : IAnimComponentUpdater {

  
  public ref float TraceDistance { get; }
  
  public IAnimParamHandle SlopeAngle { get; }
  
  public IAnimParamHandle SlopeAngleFront { get; }
  
  public IAnimParamHandle SlopeAngleSide { get; }
  
  public IAnimParamHandle SlopeHeading { get; }
  
  public IAnimParamHandle SlopeNormal { get; }
  
  public IAnimParamHandle SlopeNormal_WorldSpace { get; }
}
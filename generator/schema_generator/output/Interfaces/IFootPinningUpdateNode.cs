using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootPinningUpdateNode : IUnaryUpdateNode {

  
  public IFootPinningPoseOpFixedData_t PoseOpFixedData { get; }
  
  public ref FootPinningTimingSource TimingSource { get; }
  
// CUtlVector< CAnimParamHandle >
  public ref CUtlVector Params { get; }
  
  public ref bool ResetChild { get; }
}
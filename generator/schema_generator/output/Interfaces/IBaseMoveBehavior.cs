using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseMoveBehavior : IPathKeyFrame {

  
  public ref int PositionInterpolator { get; }
  
  public ref int RotationInterpolator { get; }
  
  public ref float AnimStartTime { get; }
  
  public ref float AnimEndTime { get; }
  
  public ref float AverageSpeedAcrossFrame { get; }
  
  public IPathKeyFrame CurrentKeyFrame { get; }
  
  public IPathKeyFrame TargetKeyFrame { get; }
  
  public IPathKeyFrame PreKeyFrame { get; }
  
  public IPathKeyFrame PostKeyFrame { get; }
  
  public ref float TimeIntoFrame { get; }
  
  public ref int Direction { get; }
}
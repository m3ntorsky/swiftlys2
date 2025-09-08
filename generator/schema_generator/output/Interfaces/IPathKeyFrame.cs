using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPathKeyFrame : ILogicalEntity {

  public ref Vector Origin { get; }
  
  public ref QAngle Angles { get; }
  
  public ref Quaternion Angle { get; }
  
  public ref CUtlSymbolLarge NextKey { get; }
  
  public ref float NextTime { get; }
  
  public IPathKeyFrame NextKey { get; }
  
  public IPathKeyFrame PrevKey { get; }
  
  public ref float MoveSpeed { get; }
  
}
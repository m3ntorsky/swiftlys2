using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITiltTwistConstraint : IBaseConstraint {

  public ref int TargetAxis { get; }
  
  public ref int SlaveAxis { get; }
  
}
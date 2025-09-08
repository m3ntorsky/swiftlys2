using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAimConstraint : IBaseConstraint {

  public ref Quaternion AimOffset { get; }
  
  public ref uint UpType { get; }
  
}
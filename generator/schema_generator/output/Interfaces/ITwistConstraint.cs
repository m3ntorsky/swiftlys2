using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITwistConstraint : IBaseConstraint {

  public ref bool Inverse { get; }
  
  public ref Quaternion ParentBindRotation { get; }
  
  public ref Quaternion ChildBindRotation { get; }
  
}
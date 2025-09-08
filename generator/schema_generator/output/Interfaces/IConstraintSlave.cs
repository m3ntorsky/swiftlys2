using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IConstraintSlave : ISchemaClass {

  public ref Quaternion BaseOrientation { get; }
  
  public ref Vector BasePosition { get; }
  
  public ref uint BoneHash { get; }
  
  public ref float Weight { get; }
  
  public ref CUtlString Name { get; }
  
}